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

      private void btnGetFromExcelRepository_Click(object sender, EventArgs e)
      {
         try
         {
            bteProductRepoExcel.Enabled = false;
            RepoExcelReader reader = new RepoExcelReader();
            reader.LoadData(bteProductRepoExcel.Text);
         }
         catch(Exception ex)
         {

         }
         finally
         {
            bteProductRepoExcel.Enabled = true;
         }


      }

      private void btnGetFieldsFromDatabase_Click(object sender, EventArgs e)
      {
         PRD_DocumentationTableAdapters.AT_DOC_MANUAL_TABLE_FIELDSTableAdapter adapter = new PRD_DocumentationTableAdapters.AT_DOC_MANUAL_TABLE_FIELDSTableAdapter();
         adapter.InsertFieldsFromDatabase();
      }

      private void btnCreateDbFieldsExcel_Click(object sender, EventArgs e)
      {
         DocCreator creator = new DocCreator();
         //creator.CreateExcelOfTableFields(Consts.CUST_CASE_DEBT_GROUP, $"{Consts.CUST_CASE_DEBT_GROUP}.xlsx");
         //creator.CreateExcelOfTableFields(Consts.AGENCY_ASSIGNMENTS_GROUP, $"{Consts.AGENCY_ASSIGNMENTS_GROUP}.xlsx");
         creator.CreateExcelOfTableFields(Consts.ALL_GROUP, $"{Consts.ALL_GROUP}.xlsx");
        }

      private void workerFieldsFromDatabase_DoWork(object sender, DoWorkEventArgs e)
      {

      }

      private void workerFieldsFromDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {

      }

      private void workerFieldsFromDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {

      }

      private void Form1_Load(object sender, EventArgs e)
      {
         RepoExcelInformation info = new RepoExcelInformation();
         info.CreateRepoExcelSettings(bteProductRepoExcel.Text, "excelinfo.txt");
      }
   }
}
