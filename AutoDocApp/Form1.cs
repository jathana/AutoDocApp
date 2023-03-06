using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoDocApp
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void bteProductRepoExcel_Click(object sender, EventArgs e)
      {
         xtraOpenFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
         if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
         {
            // Get the path of specified file.
            bteProductRepoExcel.Text = xtraOpenFileDialog1.FileName;

         }
      }

      private void btnRun_Click(object sender, EventArgs e)
      {
         RepoExcelReader reader = new RepoExcelReader();
         reader.LoadData(bteProductRepoExcel.Text, Consts.CUST_CASE_DEBT_GROUP);

         DocCreator creator = new DocCreator();
         creator.CreateExcelOfTableFields(reader, Consts.CUST_CASE_DEBT_GROUP,$"{Consts.CUST_CASE_DEBT_GROUP}.xlsx");

      }
   }
}
