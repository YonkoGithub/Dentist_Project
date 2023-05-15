using Dentist_Project.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;



namespace Dentist_Project.Forms
{
    public partial class ADD_New_Patient_Form_2 : Form
    {


        CLS_Add_New_Patient ob = new CLS_Add_New_Patient(); // Call CLS_Add_New_Patient Class and make object 
        DataTable dt = new DataTable(); // dt Declaration
        int Number_Of_Patients;  // Number_Of_Patients declaration
        string Gender; // to save Gender inDatabase during Radio Button 




        public ADD_New_Patient_Form_2()
        {
            InitializeComponent();

            //Lbl_Date_ADD_PA.Text = DateTime.Now.ToLongDateString(); // Desplay corent Date
            //Lbl_Time_ADD_PA.Text = DateTime.Now.ToLongTimeString(); // Desplay corent Date


            Combo_Box_Add_New_State_View.DataSource = ob.view_patient_state();
            Combo_Box_Add_New_State_View.DisplayMember = "state_name";
            Combo_Box_Add_New_State_View.ValueMember = "id";


            dt = ob.Show_Patient_ID(); // Show Number of colms of Patient ID

            TXT_ID_ADD_PA_F_1.Text = dt.Rows[0][0].ToString();




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


        private void TXT_ID_ADD_PA_Click(object sender, EventArgs e)
        {

        }

       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Close the Program ? ", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
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

        

        private void Choce_Img_ADD_PA_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic = new OpenFileDialog();
            pic.Filter = "Images Files :|*.jpg;*.gif;*.BMP;*.PNG";

            if (pic.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(pic.FileName);
            }
        }

        private void Btn_New_State_ADD_PA_Click(object sender, EventArgs e)
        {
            New_State_Of_Pastient f = new New_State_Of_Pastient();
            f.ShowDialog();
        }

        private void TXT_Payed_Add_Ps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TXT_Box_Remind_ADD_PA.Text = Convert.ToString(Convert.ToInt32(TXT_COST_AD_PA.Text) - Convert.ToInt32(TXT_Payed_Add_Ps.Text)); // Remind = Payed Money - Cost
            }
            catch
            {
                return;
            }
        }

        private void TXT_COST_AD_PA_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Payed_Add_Ps.Text == "") // if Patient does not Pay any Mony 
            {
                TXT_Box_Remind_ADD_PA.Text = TXT_COST_AD_PA.Text; // Remind is equal Cost
            }
            else
            {
                TXT_Box_Remind_ADD_PA.Text = Convert.ToString(Convert.ToInt32(TXT_COST_AD_PA.Text) - Convert.ToInt32(TXT_Payed_Add_Ps.Text)); // Remind = Payed Money - Cost
            }
        }

        private void Date_PICKER2_ADD_PA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Add_ADD_PA_Click(object sender, EventArgs e)
        {
            if (RAB_MALE_ADD_PA.Checked == true) // Radio Button Gender
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Famale";
            }

            byte[] img; // Covert Image to byte
            MemoryStream ms1;
            ms1 = new MemoryStream();
            pictureBox3.Image.Save(ms1, pictureBox3.Image.RawFormat);
            img = ms1.ToArray();

            // Add a New Patient to Database
            try
            {
                // Fill all Add_New_patient function 

                ob.Add_New_patient(
               Convert.ToInt32(TXT_ID_ADD_PA_F_1.Text), // convert ID txt box to int 
               TXT_TC_ADD_PA.Text,
               TXT_NAME_ADD_PA.Text,
               Convert.ToInt32(Date_AGE_ADD_PA.Text),
               Gender,
               TXT_PHONE_ADD_PA.Text,
               Date_PICKER2_ADD_PA.Value.Date,
               TXT_BOX_Email_ADD_PS.Text,
               Convert.ToDouble(TXT_COST_AD_PA.Text), // convert float txt box 
               Convert.ToDouble(TXT_Payed_Add_Ps.Text),
               Convert.ToDouble(TXT_Box_Remind_ADD_PA.Text),
                img,
               Combo_Box_Add_New_State_View.SelectedIndex.ToString());

                MessageBox.Show("a New Patient has been added succcessfully.....", "Adding New Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }

        private void Btn_Apdate_ADD_PA_Click(object sender, EventArgs e)
        {
            try
            {
                if (RAB_MALE_ADD_PA.Checked == true) // Radio Button Gender
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Famale";
                }
                byte[] img; // Covert Image to byte
                MemoryStream ms1;
                ms1 = new MemoryStream();
                pictureBox3.Image.Save(ms1, pictureBox3.Image.RawFormat);
                img = ms1.ToArray();
                // Add a New Patient to Database
                // Fill all Add_New_patient function 
                ob.Update_New_patient(
                    Convert.ToInt32(TXT_ID_ADD_PA_F_1.Text), // convert ID txt box to int 
                    TXT_TC_ADD_PA.Text,
                    TXT_NAME_ADD_PA.Text,
                    Convert.ToInt32(Date_AGE_ADD_PA.Text),
                    Gender,
                    TXT_PHONE_ADD_PA.Text,
                    Date_PICKER2_ADD_PA.Value.Date,
                    TXT_BOX_Email_ADD_PS.Text,
                    Convert.ToDouble(TXT_COST_AD_PA.Text), // convert float txt box 
                    Convert.ToDouble(TXT_Payed_Add_Ps.Text),
                    Convert.ToDouble(TXT_Box_Remind_ADD_PA.Text),
                     img,
                    Combo_Box_Add_New_State_View.SelectedIndex.ToString());

                MessageBox.Show("The Info has benn Upadted Successfully.....", "Pstient Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dt = ob.View_All_Patient();
                Patient_Manegment_Form_2.deleg.DataGrid_View_P_M_Form.DataSource = dt;
            }
            catch
            {
                return;
            }
        }

        private void Btn_Home_ADD_N_P_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_2_Form f = new Home_2_Form();
            f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TXT_ID_ADD_PA_F_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_BOX_Email_ADD_PS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
