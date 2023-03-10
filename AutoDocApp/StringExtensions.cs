using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDocApp
{
   public static class StringExtensions
   {
      /// <summary>
      /// We can use the Edit distance algorithm to determine the similarity between two strings in C#. 
      /// The Edit distance algorithm tells us how different two strings are from each other by finding 
      /// the least number of moves (add, remove, insert) required to convert one string to another. 
      /// We can even use the Jaro-Winkler distance algorithm instead of Edit distance.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static int GetEditDistance(this string x, string y)
      {
         int m = x.Length;
         int n = y.Length;

         int[][] T = new int[m + 1][];
         for (int i = 0; i < m + 1; ++i)
         {
            T[i] = new int[n + 1];
         }

         for (int i = 1; i <= m; i++)
         {
            T[i][0] = i;
         }
         for (int j = 1; j <= n; j++)
         {
            T[0][j] = j;
         }

         int cost;
         for (int i = 1; i <= m; i++)
         {
            for (int j = 1; j <= n; j++)
            {
               cost = x[i - 1] == y[j - 1] ? 0 : 1;
               T[i][j] = Math.Min(Math.Min(T[i - 1][j] + 1, T[i][j - 1] + 1),
                       T[i - 1][j - 1] + cost);
            }
         }

         return T[m][n];
      }

      public static double FindSimilarity(this string x, string y)
      {
         if (x == null || y == null)
         {
            throw new ArgumentException("Strings must not be null");
         }

         double maxLength = Math.Max(x.Length, y.Length);
         if (maxLength > 0)
         {
            // optionally ignore case if needed
            return (maxLength - GetEditDistance(x, y)) / maxLength;
         }
         return 1.0;
      }
   }
}
