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
    public partial class User_Management_Form : DevExpress.XtraEditors.XtraForm
    {

        DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
        DXL_LINQ.Table_User_Permission ob;



        public User_Management_Form()
        {
            InitializeComponent();
        }


        public void Show_Data_Table()// Show Data Table on Data Grid View
        {
            DataGrid_User_Maneg.DataSource = db.Table_User_Permissions;

            DataGrid_User_Maneg.Columns["User_ID"].Visible = false;

        }


        public void Add_Update_Button()// Add Update Button to Data Gried View 
        {
            DataGridViewButtonColumn Btn = new DataGridViewButtonColumn();
            Btn.HeaderText = "Update";
            Btn.Name = "Update";
            Btn.Text = "Update";
            Btn.UseColumnTextForButtonValue = true;
            DataGrid_User_Maneg.Columns.Add(Btn);

        }

        public void Add_Delete_Button()// Add Delete Button to Data Gried View 
        {
            DataGridViewButtonColumn Btn = new DataGridViewButtonColumn();
            Btn.HeaderText = "Remove";
            Btn.Name = "Delete";
            Btn.Text = "Delete";
            Btn.UseColumnTextForButtonValue = true;
            DataGrid_User_Maneg.Columns.Add(Btn);

        }


        public void Update_User()// #Update User Data Function
        {

            try
            {
                db = new DXL_LINQ.CLS_DXL_IINQDataContext();
                int Row_Number = (int)DataGrid_User_Maneg.CurrentRow.Cells["User_ID"].Value;
                DXL_LINQ.Table_User_Permission ob = new DXL_LINQ.Table_User_Permission();
                ob = db.Table_User_Permissions.Single(x => x.User_ID == Row_Number);
                ob.User_Name = DataGrid_User_Maneg.CurrentRow.Cells["User_Name"].Value.ToString();
                ob.User_Email = DataGrid_User_Maneg.CurrentRow.Cells["User_Email"].Value.ToString();
                ob.User_Password = DataGrid_User_Maneg.CurrentRow.Cells["User_Password"].Value.ToString();
                ob.User_Type = DataGrid_User_Maneg.CurrentRow.Cells["User_Type"].Value.ToString();
                ob.New_Patient = (bool)DataGrid_User_Maneg.CurrentRow.Cells["New_Patient"].Value;
                ob.Patients_Manegment = (bool)DataGrid_User_Maneg.CurrentRow.Cells["Patients_Manegment"].Value;
                ob.User_Manegment = (bool)DataGrid_User_Maneg.CurrentRow.Cells["User_Manegment"].Value;
                ob.Earn = (bool)DataGrid_User_Maneg.CurrentRow.Cells["Earn"].Value;
                ob.Spending = (bool)DataGrid_User_Maneg.CurrentRow.Cells["Spending"].Value;
                ob.Income = (bool)DataGrid_User_Maneg.CurrentRow.Cells["Income"].Value;
                ob.Income = (bool)DataGrid_User_Maneg.CurrentRow.Cells["Income"].Value;
                ob.New_User = (bool)DataGrid_User_Maneg.CurrentRow.Cells["New_User"].Value;
           
                db.SubmitChanges();
                MessageBox.Show("User has Upadated Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }




        public void Deleted_User()// Delete User Data Function
        {


           if( MessageBox.Show("Are You sure ?", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    db = new DXL_LINQ.CLS_DXL_IINQDataContext();
                    int Row_Number = (int)DataGrid_User_Maneg.CurrentRow.Cells["User_ID"].Value;
                    DXL_LINQ.Table_User_Permission ob = new DXL_LINQ.Table_User_Permission();
                    ob = db.Table_User_Permissions.Single(x => x.User_ID == Row_Number);
                    db.Table_User_Permissions.DeleteOnSubmit(ob);
                    db.SubmitChanges();
                    MessageBox.Show("User has Deleted Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    return;
                }

            }
        }




        
        private void User_Management_Form_Load(object sender, EventArgs e)
        {
            Show_Data_Table();// Show Data Table on Data Grid View
            Add_Update_Button();// Add Update Button to Data Gried View 
            Add_Delete_Button();// Add Delete Button to Data Gried View 
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

        private void DataGrid_User_Maneg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGrid_User_Maneg.Columns[e.ColumnIndex].Name == "Update")
            {
                Update_User();// #Update Userm Data Function
               


                
            }

            if (DataGrid_User_Maneg.Columns[e.ColumnIndex].Name == "Delete")
            {
                Deleted_User();// Delete User Data Function




            }
        }

       
    }
}