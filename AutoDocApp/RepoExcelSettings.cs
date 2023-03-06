﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutoDocApp
{
   public static class RepoExcelSettings
   {

      public class DocGroup
      {
         public string Name { get; set; }
         public string Sql { get; set; }
      }


      public static XmlDocument Xml { get; }
      static RepoExcelSettings()
      {
         Xml = new XmlDocument();
         Xml.Load("RepoExcelSettings.xml");
      }

      public static XmlNodeList GetEntityWorksheetsNodes(string docGroup)
      {
         return Xml.SelectNodes($"/root/entity_worksheets/entity_worksheet[@doc_group='{docGroup}']");
      }

      public static XmlNodeList GetAuxWorksheetsNodes(string docGroup)
      {
         return Xml.SelectNodes($"/root/aux_worksheets/aux_worksheet[@doc_group='{docGroup}']");
      }

      public static List<string> GetDocGroupTables(string docGroup)
      {
         List<string> retVal = new List<string>();
         var node = Xml.SelectSingleNode($"/root/doc_groups/doc_group[@name='{docGroup}']");
         string tablesFile = node.Attributes["tables_file"].InnerText;
         if (File.Exists(tablesFile))
         {
            retVal = File.ReadAllLines(tablesFile).ToList<string>();
         }
         return retVal;
      }

      public static DocGroup GetDocGroup(string docGroup)
      {
         DocGroup retVal = null;
         var node = Xml.SelectSingleNode($"/root/doc_groups/doc_group[@name='{docGroup}']");
         if (node != null)
         {
            retVal = new DocGroup()
            {
               Name = docGroup,
               Sql = node.Attributes["sql_file"].InnerText
            };
         }
         return retVal;
      }
   }
}
