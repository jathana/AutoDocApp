using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDocApp
{
   public class DocCreator
   {
      public DocCreator()
      {

      }

      public bool CreateExcelOfTableFields(string docGroup, string exportFilename)
      {
         bool retVal = true;

         // get table fields
         DataSet dataset = GetTableFieldsFromDatabase(docGroup);
         DataTable table = dataset.Tables[0];

         //  get tables names list in doc group
         var tablesList = table.AsEnumerable().GroupBy(x => x.Field<string>("DMTF_TABLE_NAME")).Select(x => x.Key).OrderBy(x => x).ToList();

         // create list of unique worksheet names  (table_name, worksheet name)
         List<(string TableName, string WorksheetName)> worksheetNames = GetWorksheetsNamesDictionary(tablesList);

         // Create Workbook object
         Workbook workbook = new Workbook();
         WorksheetCollection worksheets = workbook.Worksheets;

         // create Index worksheet
         CreateIndexWorksheet(workbook, worksheetNames);

         foreach (var tableName in tablesList)
         {
            // add table fields in worksheet
            var tableFields = table.AsEnumerable().Where(t => t.Field<string>("DMTF_TABLE_NAME") == tableName).ToList();

            // get unique worksheet name
            string worksheetName = GetUniqueWorksheetName(tableName, worksheetNames);

            // create worksheet with table prefix
            Worksheet worksheet = worksheets.Add(worksheetName);

            // write header
            WriteHeader(worksheet);

            //write fields rows
            WriteFieldsRows(worksheet, tableFields);

            // apply style
            StyleFieldsWorksheet(worksheet, 0, 0, tableFields.Count + 1, 7);
         }
         // save created excel file
         workbook.Save(exportFilename, SaveFormat.Xlsx);

         return retVal;
      }

      /// <summary>
      /// returns a 31 chars name to be used for excel worksheet name. Contains table name (up to 23 chars) along with table prefix in the form 'table_name'_(table_prefix)
      /// </summary>
      /// <param name="row"></param>
      /// <returns></returns>
      private string GetUniqueWorksheetName(string tableName, List<(string TableName, string WorksheetName)> worksheetNames)
      {
         return worksheetNames.Where(x=>x.TableName==tableName).Select(x=>x.WorksheetName).FirstOrDefault();
      }

      /// <summary>
      /// returns a list with pairs of table name and unique worksheet name. 31 chars name to be used for excel worksheet name. 
      /// </summary>
      /// <param name="tablesList"></param>
      /// <returns></returns>
      private List<(string TableName, string WorksheetName)> GetWorksheetsNamesDictionary(List<string> tablesList)
      {
         List<(string TableName, string WorksheetName)> retVal = new List<(string TableName, string WorksheetName)>();

         foreach (string tableName in tablesList)
         {
            // ensure unique name
            byte duplicateIndex = 0;
            string duplicateIndexStr = string.Empty;
            string worksheetName = tableName;
            while (true)
            {
               if (tableName.Length > 31)
               {
                  worksheetName = $"{tableName.Substring(0, 22)}.{duplicateIndexStr}.{tableName.Substring(tableName.Length - 7 + duplicateIndexStr.Length, 7 - duplicateIndexStr.Length)}";
               }

               // unique name found - break
               if (retVal.Where(x => x.WorksheetName.Equals(worksheetName)).Count()==0)
               {
                  retVal.Add((tableName, worksheetName));
                  break;
               }

               // name is not unique, replace '..' with '.N.' where N number starting from 1. 
               duplicateIndex++;
               duplicateIndexStr = duplicateIndex.ToString();

            }
         }

         return retVal;
      }
      private void CreateIndexWorksheet(Workbook workbook, List<(string TableName, string WorksheetName)> worksheetNames)
      {

         Worksheet indexWorkSheet = workbook.Worksheets["Sheet1"];
         // rename worksheet Sheet1 to Index Of Tables
         indexWorkSheet.Name = "Index Of Tables";

         // write index
         indexWorkSheet.Cells[0, 0].Value = "Table Name";
         int i = 0;
         foreach (var item in worksheetNames)
         {
            //string tableName = item.TableName;
            indexWorkSheet.Cells[i + 1, 0].Value = item.TableName;
            indexWorkSheet.Hyperlinks.Add($"A{i + 2}", $"A{i + 2}", $"{GetUniqueWorksheetName(item.TableName, worksheetNames)}!A1", item.TableName, item.TableName);
            i++;
         }

         // apply style
         StyleIndexWorksheet(indexWorkSheet, 0, 0, worksheetNames.Count + 1, 1);
      }

      private Style FormatAsTable(Worksheet worksheet, int startRow, int startColumn, int totalRows, int totalColumns)
      {
         // format as table
         // Adding a new List Object to the worksheet
         Aspose.Cells.Tables.ListObject listObject = worksheet.ListObjects[worksheet.ListObjects.Add(startRow, startColumn, totalRows-1, totalColumns-1, true)];

         // Adding Style to the listobject
         listObject.TableStyleType = Aspose.Cells.Tables.TableStyleType.TableStyleMedium6;

         // We get the Percent style and create a style object.
         Range range = worksheet.Cells.CreateRange(startRow, startColumn, totalRows, totalColumns);

         Cell cell = worksheet.Cells["A2"];
         Style style = cell.GetStyle();
         Font font = style.Font;
         font.Name = "Calibri";
         font.Size = 9;
         StyleFlag flag = new StyleFlag();
         range.SetStyle(style);

         // Applying freeze panes settings
         worksheet.FreezePanes(1, 0, 1, 0);

         // Auto fit
         worksheet.AutoFitColumns();
         return style;
      }

      private void StyleFieldsWorksheet(Worksheet worksheet, int startRow, int startColumn, int totalRows, int totalColumns)
      {
         // format as table
         Style style=FormatAsTable(worksheet, startRow, startColumn, totalRows, totalColumns);

         // set description column width
         worksheet.Cells.Columns[3].Width = 90;

         // set word wrap for description
         style.IsTextWrapped = true;
         worksheet.Cells.Columns[3].SetStyle(style);

         // Create an object for AutoFitterOptions
         AutoFitterOptions options = new AutoFitterOptions();

         // Set auto-fit for merged cells
         options.AutoFitWrappedTextType = AutoFitWrappedTextType.Paragraph;
         options.AutoFitMergedCellsType = AutoFitMergedCellsType.EachLine;

         // Autofit rows in the sheet(including the merged cells)
         worksheet.AutoFitRows(options);
      }

      private void StyleIndexWorksheet(Worksheet worksheet, int startRow, int startColumn, int totalRows, int totalColumns)
      {
         // format as table
         Style style = FormatAsTable(worksheet, startRow, startColumn, totalRows, totalColumns);

         // Create an object for AutoFitterOptions
         AutoFitterOptions options = new AutoFitterOptions();

         // Set auto-fit for merged cells
         options.AutoFitWrappedTextType = AutoFitWrappedTextType.Paragraph;
         options.AutoFitMergedCellsType = AutoFitMergedCellsType.EachLine;

         // Autofit rows in the sheet(including the merged cells)
         worksheet.AutoFitRows(options);
      }


      private void WriteHeader(Worksheet worksheet)
      {
         // write header
         int index = 0;
         worksheet.Cells[index, 0].Value = "Table";
         worksheet.Cells[index, 1].Value = "Field";
         worksheet.Cells[index, 2].Value = "Caption";
         worksheet.Cells[index, 3].Value = "Description";
         worksheet.Cells[index, 4].Value = "Data Type";
         worksheet.Cells[index, 5].Value = "Type";
         worksheet.Cells[index, 6].Value = "Lookup";

         // write back to index navigation
         worksheet.Hyperlinks.Add($"H1", $"H1", $"'Index Of Tables'!A1", "Back To Index", "Back To Index");
      }

      private void WriteFieldsRows(Worksheet worksheet, List<DataRow> tableFields)
      {
         //write fields info
         int index = 1;
         foreach (var tableField in tableFields)
         {
            worksheet.Cells[index, 0].Value = tableField.Field<string>("DMTF_TABLE_NAME");
            worksheet.Cells[index, 1].Value = tableField.Field<string>("DMTF_FIELD_NAME");
            worksheet.Cells[index, 2].Value = tableField.Field<string>("ALIAS_FIELD_CAPTION");
            worksheet.Cells[index, 3].Value = tableField.Field<string>("ALIAS_FIELD_DESCRIPTION");
            worksheet.Cells[index, 4].Value = tableField.Field<string>("ALIAS_FIELD_DATA_TYPE");
            worksheet.Cells[index, 5].Value = tableField.Field<string>("ALIAS_FIELD_TYPE");
            worksheet.Cells[index, 6].Value = tableField.Field<string>("ALIAS_LOOKUP_LIST");

            index++;
         }
      }


      private DataSet GetTableFieldsFromDatabase(string docGroup)
      {
         DataSet dataset = new DataSet();
         string sqlFile = RepoExcelSettings.GetDocGroup(docGroup).Sql;
         string sql = File.ReadAllText(sqlFile);
         string connectionString = ConfigurationManager.ConnectionStrings["AutoDocApp.Properties.Settings.PRD_DocumentationConnectionString"].ConnectionString;
         using (SqlConnection connection = new SqlConnection(
               connectionString))
         {

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(dataset);
            connection.Close();
         }
         return dataset;
      }


   }
}
