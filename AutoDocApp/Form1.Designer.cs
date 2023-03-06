
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
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.btnRun = new DevExpress.XtraEditors.SimpleButton();
         this.bteProductRepoExcel = new DevExpress.XtraEditors.ButtonEdit();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bteProductRepoExcel.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         this.SuspendLayout();
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.btnRun);
         this.layoutControl1.Controls.Add(this.bteProductRepoExcel);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutControl1.Location = new System.Drawing.Point(0, 0);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.Root = this.Root;
         this.layoutControl1.Size = new System.Drawing.Size(632, 423);
         this.layoutControl1.TabIndex = 0;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // btnRun
         // 
         this.btnRun.Location = new System.Drawing.Point(12, 389);
         this.btnRun.Name = "btnRun";
         this.btnRun.Size = new System.Drawing.Size(608, 22);
         this.btnRun.StyleController = this.layoutControl1;
         this.btnRun.TabIndex = 4;
         this.btnRun.Text = "Run";
         this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
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
         this.emptySpaceItem1.Size = new System.Drawing.Size(612, 353);
         this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.btnRun;
         this.layoutControlItem2.Location = new System.Drawing.Point(0, 377);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(612, 26);
         this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem2.TextVisible = false;
         // 
         // xtraOpenFileDialog1
         // 
         this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(632, 423);
         this.Controls.Add(this.layoutControl1);
         this.Name = "Form1";
         this.Text = "AutoDocApp";
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.bteProductRepoExcel.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
      private DevExpress.XtraEditors.SimpleButton btnRun;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
   }
}

