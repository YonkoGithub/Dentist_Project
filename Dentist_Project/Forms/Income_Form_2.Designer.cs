
namespace Dentist_Project.Forms
{
    partial class Income_Form_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income_Form_2));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btn_Toatal_Paid = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Toatal_Remind = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Home = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lbl_Income_Form = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Location = new System.Drawing.Point(17, 34);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1292, 568);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControl1);
            this.layoutControl2.Location = new System.Drawing.Point(12, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1268, 544);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1244, 520);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1268, 544);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1248, 524);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1292, 568);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1272, 548);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Btn_Toatal_Paid
            // 
            this.Btn_Toatal_Paid.ActiveBorderThickness = 1;
            this.Btn_Toatal_Paid.ActiveCornerRadius = 20;
            this.Btn_Toatal_Paid.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Toatal_Paid.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Toatal_Paid.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Toatal_Paid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Btn_Toatal_Paid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Toatal_Paid.BackgroundImage")));
            this.Btn_Toatal_Paid.ButtonText = "Total Paid";
            this.Btn_Toatal_Paid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Toatal_Paid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Toatal_Paid.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Toatal_Paid.IdleBorderThickness = 1;
            this.Btn_Toatal_Paid.IdleCornerRadius = 20;
            this.Btn_Toatal_Paid.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Toatal_Paid.IdleForecolor = System.Drawing.Color.DimGray;
            this.Btn_Toatal_Paid.IdleLineColor = System.Drawing.Color.Gray;
            this.Btn_Toatal_Paid.Location = new System.Drawing.Point(7, 657);
            this.Btn_Toatal_Paid.Margin = new System.Windows.Forms.Padding(8);
            this.Btn_Toatal_Paid.Name = "Btn_Toatal_Paid";
            this.Btn_Toatal_Paid.Size = new System.Drawing.Size(161, 51);
            this.Btn_Toatal_Paid.TabIndex = 1;
            this.Btn_Toatal_Paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Toatal_Paid.Click += new System.EventHandler(this.Btn_Toatal_Paid_Click_1);
            // 
            // btn_Toatal_Remind
            // 
            this.btn_Toatal_Remind.ActiveBorderThickness = 1;
            this.btn_Toatal_Remind.ActiveCornerRadius = 20;
            this.btn_Toatal_Remind.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Toatal_Remind.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Toatal_Remind.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Toatal_Remind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Toatal_Remind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Toatal_Remind.BackgroundImage")));
            this.btn_Toatal_Remind.ButtonText = "Total Remind";
            this.btn_Toatal_Remind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Toatal_Remind.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Toatal_Remind.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Toatal_Remind.IdleBorderThickness = 1;
            this.btn_Toatal_Remind.IdleCornerRadius = 20;
            this.btn_Toatal_Remind.IdleFillColor = System.Drawing.Color.White;
            this.btn_Toatal_Remind.IdleForecolor = System.Drawing.Color.DimGray;
            this.btn_Toatal_Remind.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_Toatal_Remind.Location = new System.Drawing.Point(193, 657);
            this.btn_Toatal_Remind.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Toatal_Remind.Name = "btn_Toatal_Remind";
            this.btn_Toatal_Remind.Size = new System.Drawing.Size(174, 51);
            this.btn_Toatal_Remind.TabIndex = 1;
            this.btn_Toatal_Remind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Toatal_Remind.Click += new System.EventHandler(this.btn_Toatal_Remind_Click_1);
            // 
            // Home
            // 
            this.Home.ActiveBorderThickness = 1;
            this.Home.ActiveCornerRadius = 20;
            this.Home.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Home.ActiveForecolor = System.Drawing.Color.White;
            this.Home.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.ButtonText = "Home";
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.DimGray;
            this.Home.IdleBorderThickness = 1;
            this.Home.IdleCornerRadius = 20;
            this.Home.IdleFillColor = System.Drawing.Color.White;
            this.Home.IdleForecolor = System.Drawing.Color.DimGray;
            this.Home.IdleLineColor = System.Drawing.Color.Gray;
            this.Home.Location = new System.Drawing.Point(372, 657);
            this.Home.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(153, 51);
            this.Home.TabIndex = 1;
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 596);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Lbl_Income_Form
            // 
            this.Lbl_Income_Form.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Income_Form.Location = new System.Drawing.Point(1034, 628);
            this.Lbl_Income_Form.Name = "Lbl_Income_Form";
            this.Lbl_Income_Form.Size = new System.Drawing.Size(228, 80);
            this.Lbl_Income_Form.TabIndex = 3;
            this.Lbl_Income_Form.Text = "$";
            // 
            // Income_Form_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 762);
            this.Controls.Add(this.Lbl_Income_Form);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btn_Toatal_Remind);
            this.Controls.Add(this.Btn_Toatal_Paid);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Income_Form_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income_Form_2";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Toatal_Paid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Toatal_Remind;
        private Bunifu.Framework.UI.BunifuThinButton2 Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_Income_Form;
    }
}