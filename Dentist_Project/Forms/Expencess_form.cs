using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;
using DevExpress.XtraReports.UI;

namespace Dentist_Project.Forms
{
    public partial class Expencess_form : DevExpress.XtraEditors.XtraForm
    {
        DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
        DXL_LINQ.Table_Expence ob1 = new DXL_LINQ.Table_Expence();
        private object db1;
        string file_Path;
        DateTime selected_date = DateTime.Now.Date;
        double daily_expencess;



        public Expencess_form()
        {
            InitializeComponent();
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






        public void New_Data() // New data Functtion 
        {
            ob1 = new DXL_LINQ.Table_Expence();

            Txt_Expense_No.Text = "";
            Txt_Expense_Name.Text = "";
            Txt_Expense_Value.Text = "";
            Txt_Browse_File.Text = "";
            Txt_Browse_File.Text = "";
            Txt_Notes.Text = "";
            Txt_Notes.Text = "";
            Date_Kauf.Text = "";


            Btn_save.Enabled = true;
            Btn_Annual.Enabled = false;
            Btn_Print.Enabled = false;
            Btn_Print_All.Enabled = false;
            Btn_View_File.Enabled = false;
            btn_Update.Enabled = false;
            Btn_Monthly.Enabled = false;

        }

        bool isDataValidate() // Text validation  Function 
        {
            if (Txt_Expense_No.Text.Trim() == string.Empty)
            {
                Txt_Expense_No.ErrorText = "This Field is Required";

                return false;
            }




            if (Txt_Expense_Name.Text.Trim() == string.Empty)
            {
                Txt_Expense_Name.ErrorText = "This Field is Required";

                return false;
            }




            if (Date_Kauf.Text.Trim() == string.Empty)
            {
                Date_Kauf.ErrorText = "This Field is Required";
                return false;
            }


            var db = new DXL_LINQ.CLS_DXL_IINQDataContext();
            ob1 = new DXL_LINQ.Table_Expence();
            if (db.Table_Expences.Where(x => x.Expences_No.Trim() == Txt_Expense_No.Text.Trim()

             && x.Expences_id != ob1.Expences_id).Count() > 0)

            {
                Txt_Expense_No.Text = "This Name is Registred";
                return false;
            }
            return true;
        }

        public void OpenFile() //open or  Browse File  Directory Function 
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "PDF file|*.pdf|Excel|*.xls;*.xlsx|txt(*.txt)|*.txt|All Files|*.*";
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.Title = "choose Attachment File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_Browse_File.Text = openFileDialog1.FileName;
            }
        }


        public void set_Data()  //Set_data Function 
        {


            ob1.Expences_No = Txt_Expense_No.Text;
            ob1.Expences_value = Convert.ToDouble(Txt_Expense_Value.Text);
            ob1.Expences_Name = Txt_Expense_Name.Text;
            ob1.Expences_Note = Txt_Notes.Text;
            file_Path = Txt_Browse_File.Text;
            ob1.Expences_FileName = Path.GetFileName(file_Path);

            ob1.Expences_Date = Convert.ToDateTime(Date_Kauf.EditValue);

            if (Txt_Browse_File.Text != string.Empty)
            {
                string filepath = Txt_Browse_File.Text;
                string filename = Path.GetFileName(filepath);
                string extension = Path.GetExtension(filepath);
                byte[] file = System.IO.File.ReadAllBytes(filepath);

                ob1.Expences_FileName = filename;
                ob1.Expences_File_Type = extension;
                ob1.Expences_Attachment = file;
            }
            else
            {
                ob1.Expences_FileName = null;
            }





        }


        public void Save_Data() //save Data function 
        {

            if (isDataValidate() == false)

                return;


            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            // DXL_LINQ.Table_Expence ob1 = new DXL_LINQ.Table_Expence();



            if (ob1.Expences_id == 0)
            {
                db.Table_Expences.InsertOnSubmit(ob1);
            }
            else
            {
                db.Table_Expences.Attach(ob1);
            }



            set_Data();

            db.SubmitChanges();


            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        public void show_data() // show Data Function
        {
            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
            var ob = from p in db.Table_Expences
                     select new
                     {
                         p.Expences_id,
                         p.Expences_No,
                         p.Expences_Name,
                         p.Expences_value,
                         p.Expences_Note,
                         p.Expences_FileName,
                         p.Expences_Date

                     };
            DataGrid_View.DataSource = ob;

            double sum = 0; // to calculate Total Preis 

            for (int i = 0; i < this.DataGrid_View.Rows.Count; i++)
            {
                sum = (double)(sum + (double)DataGrid_View.Rows[i].Cells["Expences_value"].Value);

            }

            Lbl_Total.Text = sum.ToString() + "$";
            //format 

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void RENAME_COLUMN() // RENAME COLUMN function
        {

            var ob = new DXL_LINQ.Table_Expence();
            DataGrid_View.Columns[nameof(ob1.Expences_id)].HeaderText = "INVOICE ID";
            DataGrid_View.Columns[nameof(ob1.Expences_No)].HeaderText = "INVOICE NO";
            DataGrid_View.Columns[nameof(ob1.Expences_Name)].HeaderText = "INVOICE Name";
            DataGrid_View.Columns[nameof(ob1.Expences_Date)].HeaderText = "INVOICE Date";
            DataGrid_View.Columns[nameof(ob1.Expences_FileName)].HeaderText = "INVOICE File";
            DataGrid_View.Columns[nameof(ob1.Expences_Note)].HeaderText = "Notes";
            DataGrid_View.Columns[nameof(ob1.Expences_value)].HeaderText = "Amount";

        }

        public void check_datagridview() //enable disable Buttons during Update process function 
        {
            if (DataGrid_View.Rows.Count <= 0)
            {
                Btn_save.Enabled = false;
                btn_Update.Enabled = false;
                //Btn_.Enabled = false;
                //  btn_delete_all.Enabled = false;
                Btn_View_File.Enabled = false;
                Btn_Print.Enabled = false;
                Btn_Print_All.Enabled = false;

            }
            else
            {
                btn_Update.Enabled = true;
                // btn_delete.Enabled = true;
                // btn_delete_all.Enabled = true;
                Btn_View_File.Enabled = true;
                Btn_Print.Enabled = true;
                Btn_Print_All.Enabled = true;
            }
        }


        public void Search_ByDate_Expencess() // Search_ByDat Fuction
        {

            if (selected_date == Search_ByDate.DateTime || selected_date == DateTime.Now.Date || selected_date == Search_ByDate.DateTime.Date)
            {
                var ob = from p in db.Table_Expences.Where(x => x.Expences_Date.Date == selected_date)
                         select new
                         {
                             p.Expences_id,
                             p.Expences_No,
                             p.Expences_Name,
                             p.Expences_value,
                             p.Expences_Note,
                             p.Expences_FileName,
                             p.Expences_Date

                         };

                DataGrid_View.DataSource = ob;
                DataGrid_View.Columns["Expences_id"].Visible = false;
                double sum_expencess = 0;
                for (int i = 0; i < DataGrid_View.Rows.Count; i++)
                {
                    sum_expencess = sum_expencess + (double)DataGrid_View.Rows[i].Cells["Expences_value"].Value;

                }

                daily_expencess = sum_expencess;
                Lbl_Total.Text = "-" + daily_expencess.ToString();


            }
        }

        public void Search_By_Month_Expencess() // seach by Month Function 
        {
            try
            {
                int selected_month = Search_ByMonthe.Month;
                int selected_year = Convert.ToInt32(Search_By_Year.SelectedItem);

                var ob = from p in db.Table_Expences.Where(x => x.Expences_Date.Month == selected_month

                         && x.Expences_Date.Year == selected_year
                         )

                         select new
                         {
                             p.Expences_id,
                             p.Expences_No,
                             p.Expences_Name,
                             p.Expences_value,
                             p.Expences_Note,
                             p.Expences_FileName,
                             p.Expences_Date

                         };

                DataGrid_View.DataSource = ob;
                DataGrid_View.Columns["Expences_id"].Visible = false;
                double sum_expencess = 0;
                for (int i = 0; i < DataGrid_View.Rows.Count; i++)
                {
                    sum_expencess = sum_expencess + (double)DataGrid_View.Rows[i].Cells["Expences_value"].Value;

                }

                daily_expencess = sum_expencess;
                Lbl_Total.Text = "-" + daily_expencess.ToString() + "$";
            }
            catch
            {
                return;
            }

           
        }

        public void Search_By_Year_Expencess()// Search by Year function 
        {

            int selected_year = Convert.ToInt32(Search_By_Year.SelectedItem);

            var ob = from p in db.Table_Expences.Where(x => x.Expences_Date.Year == selected_year
                     )

                     select new
                     {
                         p.Expences_id,
                         p.Expences_No,
                         p.Expences_Name,
                         p.Expences_value,
                         p.Expences_Note,
                         p.Expences_FileName,
                         p.Expences_Date

                     };

            DataGrid_View.DataSource = ob;
            DataGrid_View.Columns["Expences_id"].Visible = false;
            double sum_expencess = 0;
            for (int i = 0; i < DataGrid_View.Rows.Count; i++)
            {
                sum_expencess = sum_expencess + (double)DataGrid_View.Rows[i].Cells["Expences_value"].Value;

            }

            daily_expencess = sum_expencess;
            Lbl_Total.Text = "-" + daily_expencess.ToString() + "$";
         }


        public void ViewFile() // View File Function 
        {
            try
            {
                db = new DXL_LINQ.CLS_DXL_IINQDataContext();

                int r = Convert.ToInt32(this.DataGrid_View.CurrentRow.Cells["Expences_Id"].Value);
                var data = db.Table_Expences.Where(x => x.Expences_id == r).First();
                if (data.Expences_FileName == null)
                {

                    MessageBox.Show("there is no file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string pdffilename = this.DataGrid_View.CurrentRow.Cells["Expences_FileName"].Value.ToString();

                byte[] fileContent = data.Expences_Attachment.ToArray();
                System.IO.File.WriteAllBytes(pdffilename, fileContent);
                System.Diagnostics.Process.Start(pdffilename);

            }
            catch 
            {
                return; //MessageBox.Show("the Error is :" + ex, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrintSingleLine() // Print Single Line Fiunction 
        {
            try
            {
                int r;
                DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
                r = (int)this.DataGrid_View.CurrentRow.Cells[0].Value;
                if (r > 0)
                {
                    var data = db.Table_Expences.Where(x => x.Expences_id == r).ToList();


                    Reports.RPT_SINGLE_INVOICEacs ob = new Reports.RPT_SINGLE_INVOICEacs();

                    ob.DataSource = data;

                    ob.ShowPreview();
                }
            }
            catch
            {
                return;
            }
        }

        public void Print_All()// Print all Fiunction
        {
            try
            {
                Reports.Print_All ob = new Reports.Print_All();
                ob.ShowPreview();
            }
            catch
            {
                return;
            }
           
        }




        private void Search_ByDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
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

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Home_2_Form f = new Home_2_Form();
            this.Hide();
            f.ShowDialog();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            New_Data();
        }

        private void Btn_save_Click(object sender, EventArgs e) // Save Button

        {
            Save_Data();



        }

        private void Txt_Expense_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Expense_No_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Txt_Expense_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Kauf_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Txt_Expense_Name_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Btn_Browse_File_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Search_ByDate_EditValueChanged(object sender, EventArgs e)
        {
            Search_ByMonthe.Enabled = false;
            Search_ByMonthe.Enabled = false;
            Date_Kauf.Enabled = false;

            selected_date = Search_ByDate.DateTime.Date;
            Search_ByDate_Expencess();
        }

        private void Expencess_form_Load(object sender, EventArgs e)
        {
            show_data();
            RENAME_COLUMN();
        }

        private void DataGrid_View_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            check_datagridview();

            int r;
            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            r = (int)this.DataGrid_View.CurrentRow.Cells["Expences_id"].Value;
            if (r > 0)
            {
                var data = db.Table_Expences.Single(x => x.Expences_id == r);
                Txt_Expense_No.Text = data.Expences_No;
                Txt_Expense_Name.Text = data.Expences_Name;
                Txt_Expense_Value.EditValue = data.Expences_value;
                Txt_Notes.Text = data.Expences_Note;
                Txt_Browse_File.Text = data.Expences_FileName;
                Date_Kauf.EditValue = data.Expences_Date;

            }
            else
            {
                return;
            }

            Btn_save.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e) // update Button
        {

            try
            {
                db = new DXL_LINQ.CLS_DXL_IINQDataContext();

                int i = Convert.ToInt32(this.DataGrid_View.CurrentRow.Cells[0].Value);
                ob1 = new DXL_LINQ.Table_Expence();

                ob1 = db.Table_Expences.Single(x => x.Expences_id == i);


                set_Data();

                db.SubmitChanges();
                MessageBox.Show("Upated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lbl_date_des.Text = "All years";
                show_data();
            }

            catch
            {
                return;
            }
           
        }

        private void Btn_Monthly_Click(object sender, EventArgs e)
        {
            Search_By_Month_Expencess();
            RENAME_COLUMN();
        }// Montly Button

        private void Btn_Annual_Click(object sender, EventArgs e) //Annuasl Button
        {
            Search_By_Year_Expencess();
        }

        private void Btn_View_File_Click(object sender, EventArgs e)//View File Button
        {
            try
            {
                ViewFile();// View File Function 
            }
            catch
            {
                return;
            }
           
        }

        private void Btn_Print_Click(object sender, EventArgs e) //Print Butoon 
        {
            
             PrintSingleLine(); // Print Single Line Fiunction 
        }

        private void Btn_Print_All_Click(object sender, EventArgs e)
        {
            Print_All();// Print all Fiunction
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_View_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            check_datagridview();
            int r;
            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
            r = (int)this.DataGrid_View.CurrentRow.Cells["Expences_id"].Value;
            if (r > 0)
            {
                var data = db.Table_Expences.Single(x => x.Expences_id == r);
                Txt_Expense_No.Text = data.Expences_No;
                Txt_Expense_Name.Text = data.Expences_Name;
                Txt_Expense_Value.EditValue = data.Expences_value;
                Txt_Notes.Text = data.Expences_Note;
                Txt_Browse_File.Text = data.Expences_FileName;
                Date_Kauf.EditValue = data.Expences_Date;
            }
            else
            {
                return;
            }
            Btn_save.Enabled = false;
        }
    }
}