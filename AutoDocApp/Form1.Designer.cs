
namespace AutoDocApp
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
         DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
         DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
         DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
         DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
         DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.btnCreateDbFieldsExcel = new DevExpress.XtraEditors.SimpleButton();
         this.btnGetFieldsFromDatabase = new DevExpress.XtraEditors.SimpleButton();
         this.btnGetFromExcelRepository = new DevExpress.XtraEditors.SimpleButton();
         this.bteProductRepoExcel = new DevExpress.XtraEditors.ButtonEdit();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
         this.workerFieldsFromDatabase = new System.ComponentModel.BackgroundWorker();
         this.workerFieldsFromExcelRepo = new System.ComponentModel.BackgroundWorker();
         this.workerExcelCreator = new System.ComponentModel.BackgroundWorker();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bteProductRepoExcel.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         this.SuspendLayout();
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.btnCreateDbFieldsExcel);
         this.layoutControl1.Controls.Add(this.btnGetFieldsFromDatabase);
         this.layoutControl1.Controls.Add(this.btnGetFromExcelRepository);
         this.layoutControl1.Controls.Add(this.bteProductRepoExcel);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutControl1.Location = new System.Drawing.Point(0, 0);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.Root = this.Root;
         this.layoutControl1.Size = new System.Drawing.Size(632, 423);
         this.layoutControl1.TabIndex = 0;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // btnCreateDbFieldsExcel
         // 
         this.btnCreateDbFieldsExcel.Location = new System.Drawing.Point(12, 389);
         this.btnCreateDbFieldsExcel.Name = "btnCreateDbFieldsExcel";
         this.btnCreateDbFieldsExcel.Size = new System.Drawing.Size(608, 22);
         this.btnCreateDbFieldsExcel.StyleController = this.layoutControl1;
         toolTipTitleItem10.Text = "Produces database fields definitions excel file. At each execution the old excel " +
    "file is overwritten.";
         superToolTip10.Items.Add(toolTipTitleItem10);
         this.btnCreateDbFieldsExcel.SuperTip = superToolTip10;
         this.btnCreateDbFieldsExcel.TabIndex = 6;
         this.btnCreateDbFieldsExcel.Text = "Create Db Fields Excel";
         this.btnCreateDbFieldsExcel.Click += new System.EventHandler(this.btnCreateDbFieldsExcel_Click);
         // 
         // btnGetFieldsFromDatabase
         // 
         this.btnGetFieldsFromDatabase.Location = new System.Drawing.Point(12, 363);
         this.btnGetFieldsFromDatabase.Name = "btnGetFieldsFromDatabase";
         this.btnGetFieldsFromDatabase.Size = new System.Drawing.Size(608, 22);
         this.btnGetFieldsFromDatabase.StyleController = this.layoutControl1;
         toolTipTitleItem11.Text = "Inserts new fields definitions from database schema. Existing definitions remain " +
    "unmodified. Select this option to include database fields added upon new impleme" +
    "ntations.";
         superToolTip11.Items.Add(toolTipTitleItem11);
         this.btnGetFieldsFromDatabase.SuperTip = superToolTip11;
         this.btnGetFieldsFromDatabase.TabIndex = 5;
         this.btnGetFieldsFromDatabase.Text = "Get Fields From Database";
         this.btnGetFieldsFromDatabase.Click += new System.EventHandler(this.btnGetFieldsFromDatabase_Click);
         // 
         // btnGetFromExcelRepository
         // 
         this.btnGetFromExcelRepository.Location = new System.Drawing.Point(12, 337);
         this.btnGetFromExcelRepository.Name = "btnGetFromExcelRepository";
         this.btnGetFromExcelRepository.Size = new System.Drawing.Size(608, 22);
         this.btnGetFromExcelRepository.StyleController = this.layoutControl1;
         toolTipTitleItem12.Text = "Reloads fields information from excel repository. Replaces all old field defintio" +
    "ns with the new ones. Select this option when a newer excel repository exists to" +
    " get all definitions updated.";
         superToolTip12.Items.Add(toolTipTitleItem12);
         this.btnGetFromExcelRepository.SuperTip = superToolTip12;
         this.btnGetFromExcelRepository.TabIndex = 4;
         this.btnGetFromExcelRepository.Text = "Get From Excel Repository";
         this.btnGetFromExcelRepository.Click += new System.EventHandler(this.btnGetFromExcelRepository_Click);
         // 
         // bteProductRepoExcel
         // 
         this.bteProductRepoExcel.EditValue = "C:\\My\\Assigments\\Project and Product Decoupling\\-_TASK 125970_DB Documentation - " +
    "Cases-Customers-Debts\\Local_QCR_Assets_DataModel_v 12.3.xlsx";
         this.bteProductRepoExcel.Location = new System.Drawing.Point(117, 12);
         this.bteProductRepoExcel.Name = "bteProductRepoExcel";
         this.bteProductRepoExcel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
         this.bteProductRepoExcel.Size = new System.Drawing.Size(503, 20);
         this.bteProductRepoExcel.StyleController = this.layoutControl1;
         this.bteProductRepoExcel.TabIndex = 1;
         this.bteProductRepoExcel.Click += new System.EventHandler(this.bteProductRepoExcel_Click);
         // 
         // Root
         // 
         this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.Root.GroupBordersVisible = false;
         this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2});
         this.Root.Name = "Root";
         this.Root.Size = new System.Drawing.Size(632, 423);
         this.Root.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.bteProductRepoExcel;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(612, 24);
         this.layoutControlItem1.Text = "Product Repo Excel";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
         // 
         // emptySpaceItem1
         // 
         this.emptySpaceItem1.AllowHotTrack = false;
         this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
         this.emptySpaceItem1.Name = "emptySpaceItem1";
         this.emptySpaceItem1.Size = new System.Drawing.Size(612, 301);
         this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.btnGetFieldsFromDatabase;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 351);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(612, 26);
         this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem3.TextVisible = false;
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.btnCreateDbFieldsExcel;
         this.layoutControlItem4.Location = new System.Drawing.Point(0, 377);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(612, 26);
         this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem4.TextVisible = false;
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.btnGetFromExcelRepository;
         this.layoutControlItem2.Location = new System.Drawing.Point(0, 325);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(612, 26);
         this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem2.TextVisible = false;
         // 
         // xtraOpenFileDialog1
         // 
         this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
         // 
         // workerFieldsFromDatabase
         // 
         this.workerFieldsFromDatabase.WorkerReportsProgress = true;
         this.workerFieldsFromDatabase.WorkerSupportsCancellation = true;
         this.workerFieldsFromDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerFieldsFromDatabase_DoWork);
         this.workerFieldsFromDatabase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerFieldsFromDatabase_ProgressChanged);
         this.workerFieldsFromDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerFieldsFromDatabase_RunWorkerCompleted);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(632, 423);
         this.Controls.Add(this.layoutControl1);
         this.Name = "Form1";
         this.Text = "AutoDocApp";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.bteProductRepoExcel.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraEditors.ButtonEdit bteProductRepoExcel;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
      private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
      private DevExpress.XtraEditors.SimpleButton btnGetFromExcelRepository;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraEditors.SimpleButton btnGetFieldsFromDatabase;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraEditors.SimpleButton btnCreateDbFieldsExcel;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private System.ComponentModel.BackgroundWorker workerFieldsFromDatabase;
      private System.ComponentModel.BackgroundWorker workerFieldsFromExcelRepo;
      private System.ComponentModel.BackgroundWorker workerExcelCreator;
   }
}

