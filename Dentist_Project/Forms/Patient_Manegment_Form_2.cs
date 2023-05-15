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
using System.Globalization;
using System.Reflection;
using DevExpress.XtraReports.UI;
using Dentist_Project.Reports;

namespace Dentist_Project.Forms
{
    public partial class Patient_Manegment_Form_2 : Form
    {


        private static Patient_Manegment_Form_2 n; // Creater deleg to Controll Form From Another form 

        static void Cf(object sender, FormClosedEventArgs e)
        {
            n = null;
        }

        public static Patient_Manegment_Form_2 deleg   // Creater deleg to Controll Form From Another form 
        {
            get
            {

                if (n == null)
                {
                    n = new Patient_Manegment_Form_2();
                }
                return n;
            }


        }

        PL.CLS_Add_New_Patient ob = new PL.CLS_Add_New_Patient();
        DataTable dt = new DataTable();


        public void Patient_Manegment_constractor()
        {
            dt = ob.View_All_Patient();
            DataGrid_View_P_M_Form.DataSource = dt;


            //// the width of Data Grid View Colums
            DataGrid_View_P_M_Form.Columns[0].Width = 75;
            DataGrid_View_P_M_Form.Columns[1].Width = 120;
            DataGrid_View_P_M_Form.Columns[2].Width = 240;
            DataGrid_View_P_M_Form.Columns[3].Width = 55;
            DataGrid_View_P_M_Form.Columns[4].Width = 85;
            DataGrid_View_P_M_Form.Columns[5].Width = 160;
            DataGrid_View_P_M_Form.Columns[6].Width = 100;
            DataGrid_View_P_M_Form.Columns[7].Width = 250;
            DataGrid_View_P_M_Form.Columns[8].Width = 100;
            DataGrid_View_P_M_Form.Columns[9].Width = 100;
            DataGrid_View_P_M_Form.Columns[10].Width = 100;
            DataGrid_View_P_M_Form.Columns[11].Width = 100;

            // The Kind of Currency of Data griade View Accourding to System Cluture 
            DataGrid_View_P_M_Form.Columns[8].DefaultCellStyle.Format = "c";
            DataGrid_View_P_M_Form.Columns[9].DefaultCellStyle.Format = "c";
            DataGrid_View_P_M_Form.Columns[10].DefaultCellStyle.Format = "c";



            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        public Patient_Manegment_Form_2()
        {
            InitializeComponent();

            if (n == null)
            {
                n = this;
            }

            Patient_Manegment_constractor();




        }

        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        } // Program speed 









        private void Btn_Print_P_M_Form_Click(object sender, EventArgs e) // Visible contact Button List
        {
            if (PL_Print_Button_list.Visible == false)
            {
                PL_Print_Button_list.Visible = true;
            }
            else
            {
                PL_Print_Button_list.Visible = false;
            }
        }

       


        private void DataGrid_View_P_M_Form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbl_Header_P_M_Frm_Click(object sender, EventArgs e)
        {

        }

        private void Panal_Footer_P_M_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void P_M_Frm_Panel_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Contact_P_M_Form_Click(object sender, EventArgs e) // Contact Button 
        {
            if (PL_Contact_Button_list.Visible == false) // Visible contact Button List
            {
                PL_Contact_Button_list.Visible = true;
            }
            else
            {
                PL_Contact_Button_list.Visible = false;
            }
        }

        private void Btn_Send_WhatsApp_Click(object sender, EventArgs e) // Set Data On Sms Form Text Box From Data _Gread View 
        {

            PL_Contact_Button_list.Visible = false;

            Send_WhatsApp_Form.deleg.Txt_Box_Name_WattsApp.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[2].Value.ToString();
            Send_WhatsApp_Form.deleg.Txt_Box_tel_WattsApp.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[5].Value.ToString();
            Send_WhatsApp_Form.deleg.Txt_Box_From_WattsApp.Text = "Dr_Bushra_Muhamad";
            Send_WhatsApp_Form.deleg.ShowDialog();

        }

        

        private void Btn_Print_Portrait_Click(object sender, EventArgs e) // Portrait Button
        {
            PL_Print_Button_list.Visible = false; // Print Button list 

            Reports.Patient_Portasl_Report ob = new Reports.Patient_Portasl_Report();

            ob.ShowPreview();
        }

       



        private void Btn_Back_P_M_Form_Click(object sender, EventArgs e)
        {
            Home_2_Form f = new Home_2_Form();

            this.Hide();
            f.ShowDialog();
        }

        private void Btn_Refresh_P_M_Form_Click_1(object sender, EventArgs e)
        {
            Patient_Manegment_constractor();
        }

        private void Btn_Update_P_M_Form_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            ADD_New_Patient_Form_2 f = new ADD_New_Patient_Form_2(); // Open ADD_New_Patient_Form



            f.Btn_Home_ADD_N_P.Visible = true;
            f.Btn_Add_ADD_PA.Visible = false;


            f.Btn_Apdate_ADD_PA.Size = new Size(f.Btn_Add_ADD_PA.Size.Width, f.Btn_Add_ADD_PA.Size.Height * 3);


            // Bring Patient Data From Data Greade View Form and Print it in ADD_New_Patient_Form Text Form 
            f.TXT_ID_ADD_PA_F_1.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[0].Value.ToString();
            f.TXT_TC_ADD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[1].Value.ToString();
            f.TXT_NAME_ADD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[2].Value.ToString();
            f.Date_AGE_ADD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[3].Value.ToString();
            if (this.DataGrid_View_P_M_Form.CurrentRow.Cells[4].Value.ToString() == "Male")  // Bring  Gender Patient Data
            {
                f.RAB_MALE_ADD_PA.Checked = true;
            }
            else
            {
                f.RAB_ADD_PA_FAMALE.Checked = true;
            }
            f.TXT_PHONE_ADD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[5].Value.ToString();
            f.Date_PICKER2_ADD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[6].Value.ToString();
            f.TXT_BOX_Email_ADD_PS.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[7].Value.ToString();
            f.TXT_COST_AD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[8].Value.ToString();
            f.TXT_Payed_Add_Ps.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[9].Value.ToString();
            f.TXT_Box_Remind_ADD_PA.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[10].Value.ToString();
            f.Combo_Box_Add_New_State_View.SelectedIndex = Convert.ToInt32(this.DataGrid_View_P_M_Form.CurrentRow.Cells[11].Value);  // Bring State  Patient Data Convert to ToInt32


            f.ShowDialog();
        }

        private void Btn_Remove_P_M_Form_Click_1(object sender, EventArgs e) // Delete Button 
        {
            try
            {
                ob.Delete_Patient_Info(Convert.ToInt32(this.DataGrid_View_P_M_Form.CurrentRow.Cells[0].Value));

                Patient_Manegment_constractor();
            }
            catch
            {
                return;
            }
        }

        private void Btn_Print_Portrait_Click_2(object sender, EventArgs e)
        {
            PL_Print_Button_list.Visible = false; // Print Button list 

            Reports.Patient_Portasl_Report ob = new Reports.Patient_Portasl_Report();

            ob.ShowPreview();
        }

       

        private void Btn_Send_WhatsApp_Click_1(object sender, EventArgs e)
        {
            PL_Contact_Button_list.Visible = false;

            Send_WhatsApp_Form.deleg.Txt_Box_Name_WattsApp.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[2].Value.ToString();
            Send_WhatsApp_Form.deleg.Txt_Box_tel_WattsApp.Text = this.DataGrid_View_P_M_Form.CurrentRow.Cells[5].Value.ToString();
            Send_WhatsApp_Form.deleg.Txt_Box_From_WattsApp.Text = "Dr_Bushra_Muhamad";
            Send_WhatsApp_Form.deleg.ShowDialog();
        }



       

        private void Btn_Add_P_M_Form_Click_1(object sender, EventArgs e)
        {
            ADD_New_Patient_Form_2 f = new ADD_New_Patient_Form_2();

            this.Hide();
            f.ShowDialog();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure to Close the Program ?", "Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {

                this.Close();
            }

        }

        private void Textbox_Search_PM_Form_EditValueChanged(object sender, EventArgs e)
        {
            dt = ob.Search_Patient_info(Textbox_Search_PM_Form.Text);
            this.DataGrid_View_P_M_Form.DataSource = dt;
            DataGrid_View_P_M_Form.Columns[0].Width = 75;
            DataGrid_View_P_M_Form.Columns[1].Width = 160;
            DataGrid_View_P_M_Form.Columns[2].Width = 215;
            DataGrid_View_P_M_Form.Columns[3].Width = 55;
            DataGrid_View_P_M_Form.Columns[4].Width = 85;
            DataGrid_View_P_M_Form.Columns[5].Width = 140;
            DataGrid_View_P_M_Form.Columns[6].Width = 115;
            DataGrid_View_P_M_Form.Columns[7].Width = 315;
            DataGrid_View_P_M_Form.Columns[8].Width = 130;
            DataGrid_View_P_M_Form.Columns[9].Width = 130;
            DataGrid_View_P_M_Form.Columns[10].Width = 130;
            DataGrid_View_P_M_Form.Columns[11].Width = 130;
        }

        

        private void Btn_Print_LandScape_Click(object sender, EventArgs e)
        {
            PL_Print_Button_list.Visible = false; // Print Button list 

            Reports.LandScape_Reports ob = new Reports.LandScape_Reports();

            ob.ShowPreview();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
