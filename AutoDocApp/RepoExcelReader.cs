using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutoDocApp
{
   public class RepoExcelReader
   {
      public DataSet Data { get; internal set; }
      public void LoadData(string excelFilename, string group)
      {

         Data = CreateEmptyDataset();
         Workbook workbook = new Workbook(excelFilename);

         // load entity worksheets
         LoadEntityWorksheets(workbook, group, Data);

         // load aux worksheets
         LoadAuxWorksheets(workbook, group, Data);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="tableName"></param>
      /// <param name="fieldName"></param>
      /// <param name="excelTable"></param>
      /// <param name="excelColumn">ENTITY_WORKSHEET or AUX_WORKSHEET</param>
      /// <returns></returns>
      public string GetColumn(string tableName, string fieldName, bool fromAux, string excelColumn)
      {
         string retVal = string.Empty;
         // get row from aux_worksheet
         DataRow[] auxFieldRow = Data.Tables["AUX_WORKSHEET"].Select($"TABLE='{tableName}' AND FIELD_NAME='{fieldName}'");
         if (auxFieldRow.Count() > 1)
         {
            Debug.WriteLine($"Found more than one rows for entity field {tableName}.{fieldName}");
         }

         if (auxFieldRow.Count() >= 1)
         {
            if (fromAux)
            {
               retVal = auxFieldRow[0].Field<string>(excelColumn);
            }
            else
            {
               // get field from entity worksheet
               DataRow[] entityFieldRow = Data.Tables["ENTITY_WORKSHEET"]
                  .Select($"ENTITY_WORKSHEET='{auxFieldRow[0]["ENTITY_WORKSHEET"]}' AND AUX_WORKSHEET='{auxFieldRow[0]["AUX_WORKSHEET"]}' AND DRIVER_DB_FIELD='{fieldName}'");
               if (entityFieldRow.Count() > 1)
               {
                  Debug.WriteLine($"Found more than one rows for aux field {tableName}.{fieldName}");
               }

               if (entityFieldRow.Count() >= 1)
               {
                  retVal = entityFieldRow[0].Field<string>(excelColumn);
               }
            }
         }


         return retVal;
      }


      private void LoadEntityWorksheets(Workbook workbook, string group, DataSet dataset)
      {
         XmlNodeList xnList = RepoExcelSettings.GetEntityWorksheetsNodes(group);
         foreach (XmlNode xn in xnList)
         {
            // read worksheet configuration info
            string entityWorksheetName = xn.Attributes["entity_worksheet"].InnerText;
            string auxWorksheetName = xn.Attributes["aux_worksheet"].InnerText;
            int worksheetDataStart = Convert.ToInt32(GetWorksheetAttribute(xn, "data_start")?.InnerText);
            int driverDBFieldColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_driver_dbfield")?.InnerText);
            int fieldNameColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_field_name")?.InnerText);
            int descColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_description")?.InnerText);

            // get worksheet
            Worksheet worksheet = workbook.Worksheets[entityWorksheetName];
            // get last row
            int lastRow = worksheet.Cells.GetLastDataRow(driverDBFieldColIndex);
            for (int i = worksheetDataStart; i <= lastRow; i++)
            {
               var excelRow = worksheet.Cells.GetRow(i);
               DataRow row = dataset.Tables["ENTITY_WORKSHEET"].NewRow();

               row["ENTITY_WORKSHEET"] = entityWorksheetName;
               row["AUX_WORKSHEET"] = auxWorksheetName;
               row["DRIVER_DB_FIELD"] = excelRow.GetCellOrNull(driverDBFieldColIndex).Value;
               row["FIELD_NAME"] = excelRow.GetCellOrNull(fieldNameColIndex).Value;
               row["DESCRIPTION"] = excelRow.GetCellOrNull(descColIndex).Value;
               dataset.Tables["ENTITY_WORKSHEET"].Rows.Add(row);

               InsertEntityToDB(row);
            }
         }
         dataset.AcceptChanges();
      }

      private void LoadAuxWorksheets(Workbook workbook, string group, DataSet dataset)
      {
         XmlNodeList xnList = RepoExcelSettings.GetAuxWorksheetsNodes(group);
         foreach (XmlNode xn in xnList)
         {
            // read worksheet configuration info
            string entityWorksheetName = xn.Attributes["entity_worksheet"].InnerText;
            string auxWorksheetName = xn.Attributes["aux_worksheet"].InnerText;
            int worksheetDataStart = Convert.ToInt32(GetWorksheetAttribute(xn, "data_start")?.InnerText);
            int tableColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_table")?.InnerText);
            int fieldColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_field")?.InnerText);
            int fieldTypeColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_field_type")?.InnerText);
            int reserverdForColIndex = CellsHelper.ColumnNameToIndex(GetWorksheetAttribute(xn, "column_reserved_for")?.InnerText);

            // get worksheet
            Worksheet worksheet = workbook.Worksheets[auxWorksheetName];
            // get last row
            int lastRow = worksheet.Cells.GetLastDataRow(tableColIndex);
            for (int i = worksheetDataStart; i <= lastRow; i++)
            {
               var excelRow = worksheet.Cells.GetRow(i);
               DataRow row = dataset.Tables["AUX_WORKSHEET"].NewRow();

               row["ENTITY_WORKSHEET"] = entityWorksheetName;
               row["AUX_WORKSHEET"] = auxWorksheetName;
               row["TABLE"] = excelRow.GetCellOrNull(tableColIndex).Value;
               row["FIELD_NAME"] = excelRow.GetCellOrNull(fieldColIndex).Value;
               row["FIELD_TYPE"] = excelRow.GetCellOrNull(fieldTypeColIndex).Value;
               row["RESERVED_FOR"] = excelRow.GetCellOrNull(reserverdForColIndex).Value;
               dataset.Tables["AUX_WORKSHEET"].Rows.Add(row);
               InsertAuxToDB(row);
            }
         }
         dataset.AcceptChanges();
      }


      private XmlAttribute GetWorksheetAttribute(XmlNode worksheetNode, string attrName)
      {
         XmlAttribute retVal = null;
         if (worksheetNode.Attributes[attrName] != null)
         {
            retVal = worksheetNode.Attributes[attrName];
         }
         if (retVal == null)
         {
            retVal = worksheetNode.ParentNode.Attributes[attrName];
         }
         return retVal;
      }
      private DataSet CreateEmptyDataset()
      {
         DataSet dataset = new DataSet();
         DataTable entityTable = dataset.Tables.Add();
         entityTable.TableName = "ENTITY_WORKSHEET";
         entityTable.Columns.Add("ENTITY_WORKSHEET", typeof(string));
         entityTable.Columns.Add("AUX_WORKSHEET", typeof(string));
         entityTable.Columns.Add("DRIVER_DB_FIELD", typeof(string));
         entityTable.Columns.Add("FIELD_NAME", typeof(string));
         entityTable.Columns.Add("DESCRIPTION", typeof(string));


         DataTable entityAuxTable = dataset.Tables.Add();
         entityAuxTable.TableName = "AUX_WORKSHEET";
         entityAuxTable.Columns.Add("ENTITY_WORKSHEET", typeof(string));
         entityAuxTable.Columns.Add("AUX_WORKSHEET", typeof(string));
         entityAuxTable.Columns.Add("TABLE", typeof(string));
         entityAuxTable.Columns.Add("FIELD_NAME", typeof(string));
         entityAuxTable.Columns.Add("FIELD_TYPE", typeof(string));
         entityAuxTable.Columns.Add("RESERVED_FOR", typeof(string));

         dataset.AcceptChanges();

         return dataset;
      }

      #region database handling
      private void InsertAuxToDB(DataRow auxRow)
      {
         PRD_DocumentationTableAdapters.AUX_WORKSHEETTableAdapter auxAdapter = new PRD_DocumentationTableAdapters.AUX_WORKSHEETTableAdapter();
         try
         {
            auxAdapter.Insert(
                  auxRow.Field<string>("ENTITY_WORKSHEET"),
                  auxRow.Field<string>("AUX_WORKSHEET"),
                  auxRow.Field<string>("TABLE"),
                  auxRow.Field<string>("FIELD_NAME"),
                  auxRow.Field<string>("FIELD_TYPE"),
                  auxRow.Field<string>("RESERVED_FOR"));
         }
         catch (Exception ex)
         {
            Log.Write($@"ENTITY_WORKSHEET:{entityRow.Field<string>("ENTITY_WORKSHEET") }
                           AUX_WORKSHEET: {entityRow.Field<string>("AUX_WORKSHEET")}
                           DRIVER_DB_FIELD: {entityRow.Field<string>("DRIVER_DB_FIELD")}
                           FIELD_NAME: {entityRow.Field<string>("FIELD_NAME")}
                           DESCRIPTION: {entityRow.Field<string>("DESCRIPTION")}            
                  ");
            Log.Write(ex.Message);
         }
      }

      private void InsertEntityToDB(DataRow entityRow)
      {
         PRD_DocumentationTableAdapters.ENTITY_WORKSHEETTableAdapter entityAdapter = new PRD_DocumentationTableAdapters.ENTITY_WORKSHEETTableAdapter();
         try
         {
            entityAdapter.Insert(
                  entityRow.Field<string>("ENTITY_WORKSHEET"),
                  entityRow.Field<string>("AUX_WORKSHEET"),
                  entityRow.Field<string>("DRIVER_DB_FIELD"),
                  entityRow.Field<string>("FIELD_NAME"),
                  entityRow.Field<string>("DESCRIPTION"));
         }
         catch (Exception ex)
         {
            Log.Write($@"ENTITY_WORKSHEET:{entityRow.Field<string>("ENTITY_WORKSHEET") }
                           AUX_WORKSHEET: {entityRow.Field<string>("AUX_WORKSHEET")}
                           DRIVER_DB_FIELD: {entityRow.Field<string>("DRIVER_DB_FIELD")}
                           FIELD_NAME: {entityRow.Field<string>("FIELD_NAME")}
                           DESCRIPTION: {entityRow.Field<string>("DESCRIPTION")}            
                  ");
            Log.Write(ex.Message);
         }
      }

      #endregion



   }
}
