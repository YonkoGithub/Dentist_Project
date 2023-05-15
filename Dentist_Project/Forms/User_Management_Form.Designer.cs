
namespace Dentist_Project.Forms
{
    partial class User_Management_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGrid_User_Maneg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_User_Maneg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_User_Maneg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_User_Maneg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_User_Maneg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_User_Maneg.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_User_Maneg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_User_Maneg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_User_Maneg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_User_Maneg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_User_Maneg.DoubleBuffered = true;
            this.DataGrid_User_Maneg.EnableHeadersVisualStyles = false;
            this.DataGrid_User_Maneg.HeaderBgColor = System.Drawing.Color.Salmon;
            this.DataGrid_User_Maneg.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_User_Maneg.Location = new System.Drawing.Point(12, 64);
            this.DataGrid_User_Maneg.Name = "DataGrid_User_Maneg";
            this.DataGrid_User_Maneg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_User_Maneg.Size = new System.Drawing.Size(1302, 694);
            this.DataGrid_User_Maneg.TabIndex = 0;
            this.DataGrid_User_Maneg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_User_Maneg_CellContentClick);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Dentist_Project.Properties.Resources.home_512px1;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(12, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 56);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // User_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 768);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.DataGrid_User_Maneg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "User_Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Management_Form";
            this.Load += new System.EventHandler(this.User_Management_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_User_Maneg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_User_Maneg;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}