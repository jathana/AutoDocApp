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
            WriteFieldsRows(worksheet, tableFields);

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
         Aspose.Cells.Tables.ListObject listObject = worksheet.ListObjects[worksheet.ListObjects.Add("A1", $"G{rowsCount+1}", true)];

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
            worksheet.Cells[index, 4].Value = tableField.Field<string>("DMTF_FIELD_DATA_TYPE");
            worksheet.Cells[index, 5].Value = tableField.Field<string>("ALIAS_FIELD_TYPE");
            worksheet.Cells[index, 6].Value = tableField.Field<string>("ALIAS_LOOKUP_LIST");

            index++;
         }
      }


      private DataSet GetTableFieldsFromDatabase(string docGroup)
      {
         DataSet dataset = new DataSet();
         string sqlFile=RepoExcelSettings.GetDocGroup(docGroup).Sql;
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
