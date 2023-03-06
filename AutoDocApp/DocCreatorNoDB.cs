﻿using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDocApp
{
   public class DocCreatorNoDB
   {
      public DocCreatorNoDB()
      {

      }

      public bool CreateExcelOfTableFields(RepoExcelReader excelReader, string docGroup, string exportFilename)
      {
         bool retVal = true;

         // get table fields
         DataSet dataset = GetTableFieldsFromDatabase(docGroup);
         DataTable table = dataset.Tables[0];
         
         //  get tables names list in doc group
         var tables = table.AsEnumerable().GroupBy(x => x.Field<string>("tab_prefix")).Select(x => x.Key).OrderBy(x=>x).ToList();

         // Create Workbook object
         Workbook workbook = new Workbook(); 
         WorksheetCollection worksheets = workbook.Worksheets;
         foreach (var tablePrefix in tables)
         {
            // create worksheet with table prefix
            Worksheet worksheet = worksheets.Add(tablePrefix);

            // add table fields in worksheet
            var tableFields = table.AsEnumerable().Where(t => t.Field<string>("tab_prefix") == tablePrefix).ToList();

            // write header
            WriteHeader(worksheet);

            //write fields rows
            WriteFieldsRows(worksheet, tableFields, excelReader);

            // apply style
            StyleWorksheet(worksheet, tableFields.Count);
         }
         // save created excel file
         workbook.Save(exportFilename, SaveFormat.Xlsx); 

         return retVal;
      }

      private void StyleWorksheet(Worksheet worksheet, int rowsCount)
      {
         // format as table
         // Adding a new List Object to the worksheet
         Aspose.Cells.Tables.ListObject listObject = worksheet.ListObjects[worksheet.ListObjects.Add("A1", $"F{rowsCount+1}", true)];

         // Adding Style to the listobject
         listObject.TableStyleType = Aspose.Cells.Tables.TableStyleType.TableStyleMedium6;

         // We get the Percent style and create a style object.
         Range range = worksheet.Cells.CreateRange(0, 0, rowsCount+1, 10);

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
         worksheet.Cells.Columns[2].Width = 90;

         // set word wrap for description
         style.IsTextWrapped = true;
         worksheet.Cells.Columns[2].SetStyle(style);

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
         worksheet.Cells[index, 2].Value = "Description";
         worksheet.Cells[index, 3].Value = "Data Type";
         worksheet.Cells[index, 4].Value = "Type";
         worksheet.Cells[index, 5].Value = "Foreign Key";
      }

      private void WriteFieldsRows(Worksheet worksheet, List<DataRow> tableFields, RepoExcelReader excelReader)
      {
         //write fields info
         int index = 1;
         foreach (var tableField in tableFields)
         {
            worksheet.Cells[index, 0].Value = tableField.Field<string>("TABLE_NAME");
            worksheet.Cells[index, 1].Value = tableField.Field<string>("FIELD_NAME");
            worksheet.Cells[index, 2].Value = excelReader.GetColumn(tableField.Field<string>("TABLE_NAME"), tableField.Field<string>("FIELD_NAME"), false, "DESCRIPTION");
            worksheet.Cells[index, 3].Value = tableField.Field<string>("FIELD_DATATYPE");
            worksheet.Cells[index, 4].Value = excelReader.GetColumn(tableField.Field<string>("TABLE_NAME"), tableField.Field<string>("FIELD_NAME"), true, "FIELD_TYPE");
            worksheet.Cells[index, 5].Value = tableField.Field<string>("IS_FOREIGN_KEY");

            index++;
         }
      }


      private DataSet GetTableFieldsFromDatabase(string docGroup)
      {
         DataSet dataset = new DataSet();
         string tables = string.Join(",", RepoExcelSettings.GetDocGroupTables(docGroup).AsQueryable().Select(x=>$"'{x}'").ToArray());
         string sql = $@"SELECT 
               col.[name] as FIELD_NAME, 
               OBJECT_NAME(col.object_id) as TABLE_NAME,
               col.max_length,
               col.precision,
               col.scale,
               CASE 
               WHEN t.name='nvarchar' THEN t.name + '(' + CONVERT(NVARCHAR,col.max_length) + ')'
               WHEN t.name='decimal' THEN t.name + '(' + CONVERT(NVARCHAR,col.precision) + ',' + CONVERT(NVARCHAR,col.scale) +')'
               ELSE t.name
               END as FIELD_DATATYPE,
               tab.tab_prefix,
               CASE WHEN fkc.referenced_column_id IS NULL THEN '' ELSE 'FK' END AS IS_FOREIGN_KEY
               FROM sys.columns col WITH(NOLOCK)
               INNER JOIN sys.tables st WITH(NOLOCK) ON st.object_id=col.object_id
               INNER JOIN sys.types t ON col.user_type_id = t.user_type_id
               INNER JOIN Tables tab with(nolock) ON tab.tab_name=OBJECT_NAME(col.object_id)
               LEFT JOIN sys.foreign_key_columns fkc WITH(NOLOCK) ON fkc.parent_column_id=col.column_id and fkc.parent_object_id=st.object_id
               WHERE st.name in ({tables})
               order by tab.tab_name, col.column_id";

         string connectionString = ConfigurationManager.ConnectionStrings["AutoDocApp.Properties.Settings.QBCollection_Plus_23_1ConnectionString"].ConnectionString;
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
