using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Project.Forms
{



    public partial class Home_2_Form : Form
 {

        private static Home_2_Form n; // Creater deleg to Controll Form From Another form 
        private int user_ID;

        static void Cf(object sender, FormClosedEventArgs e)
        {
            n = null;
        }

        public static Home_2_Form deleg   // Creater deleg to Controll Form From Another form 
        {
            get
            {

                if (n == null)
                {
                    n = new Home_2_Form();
                }
                return n;
            }


        }




        public Home_2_Form()
        {
            InitializeComponent();


            if (n == null)
            {
                n = this;
            }
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



       

        private void BTN_HOME_CLOSE_Click(object sender, EventArgs e)
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

        private void BTN_HOME_MAX_Click(object sender, EventArgs e)
        {
           

            if (WindowState == FormWindowState.Normal) // if WnForm was normal
            {
                this.WindowState = FormWindowState.Maximized; // make WinForm Maximiz
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // make WinForm normal
            }
        }

        private void BTN_HOME_MIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void btn_Patients_Click(object sender, EventArgs e)
        {
            if (Patients_Panel_Btn.Visible == false)
            {
                Patients_Panel_Btn.Visible = true;
            }

            else
            {
                Patients_Panel_Btn.Visible = false;
            }



        }

        private void BTN_HOME_Staffs_Click(object sender, EventArgs e)
        {

            if (Pnl_Staffs.Visible == false)
            {
                Pnl_Staffs.Visible = true;
            }
            else
            {
                Pnl_Staffs.Visible = false;
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Expencess_form f = new Expencess_form();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_Consumption_Click(object sender, EventArgs e)
        {
            if (pnl_Consumption.Visible == false)
            {
                pnl_Consumption.Visible = true;
            }
            else
            {
                pnl_Consumption.Visible = false;
            }
        }

        private void BTN_HOME_EransDebts_Click(object sender, EventArgs e)
        {
            if (Pnl_Errand.Visible == false)
            {
                Pnl_Errand.Visible = true;
            }
            else
            {
                Pnl_Errand.Visible = false;
            }
        }

       

        private void BTN_HOME_AddnewPatents_Click(object sender, EventArgs e)
        {
            ADD_New_Patient_Form_2 f = new ADD_New_Patient_Form_2();
            this.Hide();
            f.ShowDialog();
        }

        private void BTN_HOME_PA_Ma_Click(object sender, EventArgs e)
        {
            Patient_Manegment_Form_2 f = new Patient_Manegment_Form_2();

            this.Hide();
            f.ShowDialog();
        }

        private void BTN_HOME_Income_Click(object sender, EventArgs e)
        {

            this.Hide();
            Forms.Income_Form_2 f = new Forms.Income_Form_2();
            f.ShowDialog();
        }

        private void BTN_Return_To_Login_Click(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            this.Hide();
            f.ShowDialog();
        }

        private void BTN_HOME_NewStaffs_Click(object sender, EventArgs e)
        {
            Add_User_Form f = new Add_User_Form();
            this.Hide();
            f.ShowDialog();
        }

        private void BTN_HOME_Eames_Click(object sender, EventArgs e)
        {
            Errands_Form f = new Errands_Form();
            this.Hide();
            f.ShowDialog();
            
        }

        private void BTN_HOME_ST_MAN_Click(object sender, EventArgs e)
        {
            User_Management_Form f = new User_Management_Form();
            this.Hide();
            f.ShowDialog();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
