using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Dentist_Project.PL;

// login form 

namespace Dentist_Project.Forms
{
    public partial class Login_Form : Form // login form 
    {








        DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

        CLS_Lgin log = new CLS_Lgin(); // call CLS_Login class 
        string type; // creat type to sore CheckBox  Admin and user 



        private static Login_Form n; // Creater deleg to Controll Form From Another form 

        static void Cf(object sender, FormClosedEventArgs e)
        {
            n = null;
        }

        public static Login_Form deleg   // Creater deleg to Controll Form From Another form 
        {
            get
            {

                if (n == null)
                {
                    n = new Login_Form();
                }
                return n;
            }


        }

        public void StartSplashform()// Start Splash form Screen Functhon;
        {
            Application.Run(new SplashScreen());
        }

        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        public Login_Form()
        {
            
            Thread th = new Thread(new ThreadStart(StartSplashform));
            th.Start();
            Thread.Sleep(5000);

            

            InitializeComponent();

          


            th.Abort();
            if (n == null)
            {
                n = this;
            }


        }


        public void Login_Button()// Login Button Function 
        {
            if (RBTN_Admin.Checked)
            {
                type = "Admin";
            }
            else
            {
                type = "User";
            }

            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();


            var user_Login = db.Table_User_Permissions.Single(x => x.User_Name == TXB_UserName.Text &&

           x.User_Password == TXB_Password.Text && x.User_Type == type);


            this.Hide();

            Home_2_Form f = new Home_2_Form();

           

            if (user_Login.New_Patient == false)
            {

                f.BTN_HOME_AddnewPatents.Enabled = false;
            }


            if (user_Login.Patients_Manegment == false)
            {

                f.BTN_HOME_PA_Ma.Enabled = false;
            }

            if (user_Login.New_User == false)
            {

                f.BTN_HOME_NewStaffs.Enabled = false;
            }

            if (user_Login.User_Manegment == false)
            {

                f.BTN_HOME_ST_MAN.Enabled = false;
            }

            if (user_Login.Income == false)
            {

                f.BTN_HOME_Income.Enabled = false;
            }

            if (user_Login.Spending == false)
            {

                 f.BTN_HOME_Spending.Enabled = false;
            }

            if (user_Login.Earn == false)
            {

                f.BTN_HOME_Eames.Enabled = false;
            }

            f.ShowDialog();

        }
       

        private void BTN_Close_login_Form_Click(object sender, EventArgs e)// Close Button login_Form 
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TXB_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void BTN_Login_Click(object sender, EventArgs e) // to open Home_Form during klick on Login Button and check if user and pass are correct 
        {
            try
            {
                Login_Button();// Login Button Function 
            }



            catch
            {
                MessageBox.Show("username or password is incorrect ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Close the Program?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void RBTN_Admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       


       

        private void TXB_Password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(this.WindowState ==FormWindowState.Normal|| this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
