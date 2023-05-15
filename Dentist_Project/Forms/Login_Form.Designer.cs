
namespace Dentist_Project.Forms
{
    partial class Login_Form
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
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.BTN_Login = new DevExpress.XtraEditors.SimpleButton();
            this.RBTN_Admin = new System.Windows.Forms.RadioButton();
            this.RBTN_User = new System.Windows.Forms.RadioButton();
            this.TXB_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXB_UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(905, 223);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(10);
            this.separatorControl1.Size = new System.Drawing.Size(9, 9);
            this.separatorControl1.TabIndex = 3;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Login.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BTN_Login.Appearance.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BTN_Login.Appearance.Options.UseBackColor = true;
            this.BTN_Login.Appearance.Options.UseFont = true;
            this.BTN_Login.Appearance.Options.UseForeColor = true;
            this.BTN_Login.Location = new System.Drawing.Point(190, 608);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(240, 30);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // RBTN_Admin
            // 
            this.RBTN_Admin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RBTN_Admin.AutoSize = true;
            this.RBTN_Admin.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Admin.Location = new System.Drawing.Point(124, 560);
            this.RBTN_Admin.Name = "RBTN_Admin";
            this.RBTN_Admin.Size = new System.Drawing.Size(88, 27);
            this.RBTN_Admin.TabIndex = 2;
            this.RBTN_Admin.TabStop = true;
            this.RBTN_Admin.Text = "Admin";
            this.RBTN_Admin.UseVisualStyleBackColor = true;
            this.RBTN_Admin.CheckedChanged += new System.EventHandler(this.RBTN_Admin_CheckedChanged);
            // 
            // RBTN_User
            // 
            this.RBTN_User.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RBTN_User.AutoSize = true;
            this.RBTN_User.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_User.Location = new System.Drawing.Point(429, 560);
            this.RBTN_User.Name = "RBTN_User";
            this.RBTN_User.Size = new System.Drawing.Size(67, 27);
            this.RBTN_User.TabIndex = 3;
            this.RBTN_User.TabStop = true;
            this.RBTN_User.Text = "User";
            this.RBTN_User.UseVisualStyleBackColor = true;
            // 
            // TXB_Password
            // 
            this.TXB_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_Password.AutoSize = true;
            this.TXB_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXB_Password.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXB_Password.HintForeColor = System.Drawing.Color.Empty;
            this.TXB_Password.HintText = "Password";
            this.TXB_Password.isPassword = false;
            this.TXB_Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXB_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.TXB_Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXB_Password.LineThickness = 4;
            this.TXB_Password.Location = new System.Drawing.Point(124, 495);
            this.TXB_Password.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXB_Password.Name = "TXB_Password";
            this.TXB_Password.Size = new System.Drawing.Size(387, 40);
            this.TXB_Password.TabIndex = 1;
            this.TXB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXB_Password.OnValueChanged += new System.EventHandler(this.TXB_Password_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(436, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doc ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Have a good day";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dentist_Project.Properties.Resources._5540021;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 707);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dentist_Project.Properties.Resources.Screenshot_123;
            this.pictureBox2.Location = new System.Drawing.Point(29, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(539, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BTN_Login);
            this.panel1.Controls.Add(this.RBTN_User);
            this.panel1.Controls.Add(this.TXB_UserName);
            this.panel1.Controls.Add(this.TXB_Password);
            this.panel1.Controls.Add(this.RBTN_Admin);
            this.panel1.Location = new System.Drawing.Point(732, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 690);
            this.panel1.TabIndex = 13;
            // 
            // TXB_UserName
            // 
            this.TXB_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_UserName.AutoSize = true;
            this.TXB_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXB_UserName.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXB_UserName.HintForeColor = System.Drawing.Color.Empty;
            this.TXB_UserName.HintText = "User Name";
            this.TXB_UserName.isPassword = false;
            this.TXB_UserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXB_UserName.LineIdleColor = System.Drawing.Color.Gray;
            this.TXB_UserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXB_UserName.LineThickness = 4;
            this.TXB_UserName.Location = new System.Drawing.Point(124, 428);
            this.TXB_UserName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXB_UserName.Name = "TXB_UserName";
            this.TXB_UserName.Size = new System.Drawing.Size(393, 40);
            this.TXB_UserName.TabIndex = 1;
            this.TXB_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXB_UserName.OnValueChanged += new System.EventHandler(this.TXB_Password_OnValueChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1312, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXB_Password;
        private System.Windows.Forms.RadioButton RBTN_User;
        private System.Windows.Forms.RadioButton RBTN_Admin;
        private DevExpress.XtraEditors.SimpleButton BTN_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXB_UserName;
    }
}