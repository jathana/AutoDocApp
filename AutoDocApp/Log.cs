using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDocApp
{
   public static class Log
   {
      private static string LogFile = "Log.txt";
      public static void Write(string msg)
      {
         File.AppendAllLines(LogFile, new string[] { $"{DateTime.Now} : {msg}"});
      }
   }
}
