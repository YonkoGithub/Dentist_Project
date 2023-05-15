using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Project.Forms
{
    public partial class Add_User_Form : DevExpress.XtraEditors.XtraForm

    {
        DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
        DXL_LINQ.Table_User_Permission ob = new DXL_LINQ.Table_User_Permission();
       
        public Add_User_Form()
        {
            InitializeComponent();
           

        }

        string Message_Error_Text = "This Field is required"; // Message Error

        bool ValidateData() //user  input validation Data Function 
        {
            if (Txt_User_Name.Text.Trim() == string.Empty)
            {
                Txt_User_Name.ErrorText = Message_Error_Text;
                return false;
            }

            if (Txt_User_Email.Text.Trim() == string.Empty)
            {
                Txt_User_Email.ErrorText = Message_Error_Text;
                return false;
            }


            if (Txt_User_Password.Text.Trim() == string.Empty)
            {
                Txt_User_Password.ErrorText = Message_Error_Text;
                return false;
            }


            if (Txt_User_Conferm_Password.Text.Trim() == string.Empty)
            {
                Txt_User_Conferm_Password.ErrorText = Message_Error_Text;
                return false;
            }


            if(Txt_User_Password.Text != Txt_User_Conferm_Password.Text) // Conferm Pass word 
            {
                Txt_User_Conferm_Password.ErrorText = "password is not matched";
                return false;
            }

            db = new DXL_LINQ.CLS_DXL_IINQDataContext();
            ob = new DXL_LINQ.Table_User_Permission();


            if (db.Table_User_Permissions.Where(x => x.User_ID != ob.User_ID && x.User_Email == Txt_User_Email.Text.Trim()).Count() > 0)
            {
                Txt_User_Email.ErrorText = "This Field is exist .. Please try another Name";
                return false;
            }
            return true;

        }



        public void Set_Data() // Set data Function 
        {


            //DatabaseTable             form
            ob.User_Name = Txt_User_Name.Text;
            ob.User_Email = Txt_User_Email.Text;
            ob.User_Password = Txt_User_Password.Text;


            // set ComboBox Data to DataBase
            if (comboBox_UserType.SelectedIndex == 0) 
            {
                ob.User_Type = comboBox_UserType.SelectedText;

            }
            else
            {
                ob.User_Type = comboBox_UserType.SelectedText;
            }

            // set User Permission CheckBox to DataBase

            if(Earn_CheckBox.Checked == true)// Form CheckBox
            {
                ob.Earn = true;     // Database Table
            }
            else
            {
                ob.Earn = false;
            }


            if (Checkbox_Income.Checked == true)// Form CheckBox
            {
                ob.Income = true;     // Database Table
            }
            else
            {
                ob.Income = false;
            }





            if (Spending.Checked == true)// Form CheckBox
            {
                ob.Spending = true;     // Database Table
            }
            else
            {
                ob.Spending = false;
            }


            if (Checkbox_New_User.Checked == true)// Form CheckBox
            {
                ob.New_User = true;     // Database Table
            }
            else
            {
                ob.New_User = false;
            }



            if (Checkbox_New_Patient.Checked == true)// Form CheckBox
            {
                ob.New_Patient = true;     // Database Table
            }
            else
            {
                ob.New_Patient = false;
            }

            if (Checkbox_User_Management.Checked == true)// Form CheckBox
            {
                ob.User_Manegment = true;     // Database Table
            }
            else
            {
                ob.User_Manegment = false;
            }


            if (Checkbox_PatientsManagement.Checked == true)// Form CheckBox
            {
                ob.Patients_Manegment = true;     // Database Table
            }
            else
            {
                ob.Patients_Manegment = false;
            }


        }


       public void save_Data() //Save data Function
        {

            try
            {
                if (ValidateData() == false)  //user  input validation Data Function
                {
                    return;
                }


                if(ob.User_ID == 0)
                {
                    db.Table_User_Permissions.InsertOnSubmit(ob);

                }
                else
                {
                    db.Table_User_Permissions.Attach(ob);

                }
                Set_Data();
                db.SubmitChanges();

                MessageBox.Show("New User has saved Successfully", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch
            {
                return;
            }
         
        }







        private void Txt_User_Password_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange_1(object sender, EventArgs e)
        {
            Earn_CheckBox.Size = new Size(50, 60);
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Home_2_Form f = new Home_2_Form();
            this.Hide();
            f.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            save_Data();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            this.Hide();
            f.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Add_User_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}