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
   public class RepoExcelInformation
   {
      internal class WorksheetInfo
      {
         public string Name { get; set; }
         public int DataStart { get; set; }

         public override string ToString()
         {
            return $"Name:{Name}";
         }
      }
      internal class EntityWorksheetInfo : WorksheetInfo
      {

         public string AuxWorksheetName { get; set; }
         public bool DriverDBFieldName { get; set; }
         public bool FieldCaption { get; set; }
         public bool Description { get; set; }
         public override string ToString()
         {
            return $"{base.ToString()}";
         }
      }

      internal class AuxWorksheetInfo : WorksheetInfo
      {

         public string EntityWorksheetName { get; set; }
         public bool TableName { get; set; }
         public bool FieldName { get; set; }
         public bool FieldType { get; set; }
         public bool ReservedFor { get; set; }

      }
      private List<WorksheetInfo> _WorksheetsInfo;
      private List<string> _Errors;

      public RepoExcelInformation()
      {
         _WorksheetsInfo = new List<WorksheetInfo>();
         _Errors = new List<string>();

      }

      public void CreateRepoExcelSettings(string repoExcelFilename, string outputFile)
      {

         Clear();
         LoadRepoExcelSettings(repoExcelFilename);
         PrintErrors();
         CreateRepoExcelSettings();
      }


      private void CreateRepoExcelSettings()
      {
         
         StringBuilder builder = new StringBuilder();
         foreach (var worksheet in _WorksheetsInfo.Where(x=>x is EntityWorksheetInfo).Select(x=>x as EntityWorksheetInfo))
         {
            builder.AppendLine($"<entity_worksheet entity_worksheet=\"{worksheet.Name}\" aux_worksheet=\"{worksheet.AuxWorksheetName}\" />");
         }
         builder.AppendLine();
         builder.AppendLine();
         builder.AppendLine();
         foreach (var worksheet in _WorksheetsInfo.Where(x => x is AuxWorksheetInfo).Select(x => x as AuxWorksheetInfo))
         {            
             builder.AppendLine($"<aux_worksheet entity_worksheet=\"{worksheet.EntityWorksheetName}\" aux_worksheet=\"{worksheet.Name}\" />");
         }
         Debug.WriteLine(builder.ToString());
      }


      private void PrintErrors()
      {
         foreach (var error in _Errors)
         {
            Debug.WriteLine(error);
         }
      }



      private void Clear()
      {
         _WorksheetsInfo.Clear();
         _Errors.Clear();
      }

      private void LoadRepoExcelSettings(string repoExcelFilename)
      {
         Workbook workbook = new Workbook(repoExcelFilename);
         for (int i = 0; i < workbook.Worksheets.Count; i++)
         {
            var worksheet = workbook.Worksheets[i];
            if (worksheet.Name.StartsWith("Aux_"))
            {
               var auxWorksheet = worksheet;
               var entityWorksheet = workbook.Worksheets[i - 1];
               try
               {
                  AddAuxWorksheet(auxWorksheet, entityWorksheet.Name);
               }
               catch (Exception ex)
               {
                  _Errors.Add(ex.Message);
               }
               try
               {
                  AddEntityWorksheet(entityWorksheet, auxWorksheet.Name);
               }
               catch (Exception ex)
               {
                  _Errors.Add(ex.Message);
               }
            }
         }
      }

      private void AddEntityWorksheet(Worksheet worksheet, string auxWorksheetName)
      {
         _WorksheetsInfo.Add(
                     new EntityWorksheetInfo()
                     {
                        Name = worksheet.Name,
                        DataStart = GetEntityDataStart(worksheet),
                        Description = CheckFieldHeader(worksheet, "Description"),
                        DriverDBFieldName = CheckFieldHeader(worksheet, "DriverDBField"),
                        FieldCaption = CheckFieldHeader(worksheet, "Field Name"),
                        AuxWorksheetName = auxWorksheetName
                     });
      }

      private void AddAuxWorksheet(Worksheet worksheet, string entityWorksheetName)
      {
         _WorksheetsInfo.Add(
                     new AuxWorksheetInfo()
                     {
                        Name = worksheet.Name,
                        DataStart = GetAuxDataStart(worksheet),
                        FieldName = CheckFieldHeader(worksheet, "Field"),
                        TableName = CheckFieldHeader(worksheet, "Table"),
                        FieldType = CheckFieldHeader(worksheet, "Type"),
                        ReservedFor = CheckFieldHeader(worksheet, "Reserved for"),
                        EntityWorksheetName = entityWorksheetName
                     });
      }


      private int GetAuxDataStart(Worksheet worksheet)
      {
         FindOptions findOptions = new FindOptions();
         findOptions.LookInType = LookInType.Values;

         // Finding the cell containing the specified formula
         Cell cellTable = worksheet.Cells.Find("Table", null, findOptions);
         Cell cellField = worksheet.Cells.Find("Field", null, findOptions);
         Cell cellType = worksheet.Cells.Find("Type", null, findOptions);
         Cell cellReservedFor = worksheet.Cells.Find("Reserved for", null, findOptions);

         if (cellTable == null || cellField == null || cellType == null || cellReservedFor == null)
         {
            throw new Exception($"'{worksheet.Name}' aux Fields Header is missing");
         }

         if (cellTable.Row == cellField.Row && cellField.Row == cellType.Row && cellType.Row == cellReservedFor.Row)
            return cellTable.Row + 1;
         else
         {
            throw new Exception($"Aux Fields Header are not in the same line '{worksheet.Name}'");
         }

      }

      private int GetEntityDataStart(Worksheet worksheet)
      {
         FindOptions findOptions = new FindOptions();
         findOptions.LookInType = LookInType.Values;

         // Finding the cell containing the specified formula
         Cell cellDriverDBField = worksheet.Cells.Find("DriverDBField", null, findOptions);
         Cell cellFieldName = worksheet.Cells.Find("Field Name", null, findOptions);
         Cell cellDescription = worksheet.Cells.Find("Description", null, findOptions);

         if (cellDriverDBField == null || cellFieldName == null || cellDescription == null)
         {
            throw new Exception($"'{worksheet.Name}' entity Fields Header is missing");
         }


         if (cellDriverDBField.Row == cellFieldName.Row && cellFieldName.Row == cellDescription.Row)
            return cellDriverDBField.Row + 1;
         else
         {
            throw new Exception($"Entity Fields Header are not in the same line '{worksheet.Name}'");
         }

      }
      private bool CheckFieldHeader(Worksheet worksheet, string fieldHeader)
      {
         FindOptions findOptions = new FindOptions();
         findOptions.LookInType = LookInType.Values;

         // Finding the cell containing the specified formula
         Cell cellTable = worksheet.Cells.Find(fieldHeader, null, findOptions);
         return cellTable != null;
      }



   }
}
