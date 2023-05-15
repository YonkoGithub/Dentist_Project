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
    public partial class Errands_Form : DevExpress.XtraEditors.XtraForm
    {

       


        DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
      
        double Total_Income = 0;
        double Total_Expencess = 0;
        double Daily_Income = 0;
        double Daily_Expencess = 0;
        double Monthly_Income = 0;
        double Monthly_Expencess = 0;
        double Yearly_Income = 0;
        double Yearly_Expencess = 0;




        public Errands_Form()
        {
            InitializeComponent();

          
        }




        public void Get_All_Income() // Get All Income Function 
        {
            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            var ob = from p in db.Table_Patients
                     select new
                     {
                         p.Patient_name,
                         p.Patient_date,
                         p.paied,
                     };


            double Sum_All_Income = 0;
            DataGrid_dayliy_Eear.DataSource = ob;

            for (int i = 0; i < DataGrid_dayliy_Eear.Rows.Count; i++)
            {
                Sum_All_Income = Sum_All_Income + (double)DataGrid_dayliy_Eear.Rows[i].Cells["paied"].Value;

            }

            Total_Income = Sum_All_Income;
            lbl_All_Income.Text = Sum_All_Income.ToString() + " " + "$";
        }


        public void Get_All_Expencess() // Get All Expencess Function 
        {
            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            var ob = from p in db.Table_Expences
                     select new
                     {
                         p.Expences_Name,
                         p.Expences_value,
                         p.Expences_Date.Date,
                     };


            double Sum_All_Expencess = 0;
            DataGrid_dayliy_Exp.DataSource = ob;

            for (int i = 0; i < DataGrid_dayliy_Exp.Rows.Count; i++)
            {
                Sum_All_Expencess = Sum_All_Expencess + (double)DataGrid_dayliy_Exp.Rows[i].Cells["Expences_value"].Value;

            }

            Total_Expencess = Sum_All_Expencess;
            lbl_All_Expencess.Text = "-" + Sum_All_Expencess.ToString() + " " + "$";
        }


        public void Get_All_Earn() //Get All Earn Function
        {
            double All_Earn = Total_Income - Total_Expencess;


            lbl_All_Earns.Text = All_Earn.ToString() + " " + "$";
        }


        public void Get_All_Dayliy_Income()//Get All Daily Income Function
        {

            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
           
            DateTime selected_date = dateEdit1.DateTime.Date;
          


            var ob = from p in db.Table_Patients.Where(x => x.Patient_date == selected_date)
                     select new
                     {
                         p.Patient_name,
                         p.Patient_date,
                         p.paied
                     };


            double Sum_All_Daily_Income = 0;
            DataGrid_dayliy_Eear.DataSource = ob;
          

            for (int i = 0; i < DataGrid_dayliy_Eear.Rows.Count; i++)
            {
                Sum_All_Daily_Income = Sum_All_Daily_Income + (double)DataGrid_dayliy_Eear.Rows[i].Cells["paied"].Value;

            }

            Daily_Income = Sum_All_Daily_Income;

            lb_D_Earn_Value.Text = Sum_All_Daily_Income.ToString() + " " + "$";
        }


        public void GetAll_Daily_Expenses() //Get All Daily Expendses Function
        {
            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();
           
            DateTime selected_date = dateEdit1.DateTime;


            var ob = from p in db.Table_Expences.Where(x => x.Expences_Date == selected_date)
                     select new
                     {
                         p.Expences_Name,
                         p.Expences_value,
                         p.Expences_Date
                      
                     };

        
            double Sum_All_Daily_Expenses = 0;
            DataGrid_dayliy_Exp.DataSource = ob;

            for (int i = 0; i < DataGrid_dayliy_Exp.Rows.Count; i++)
            {
                Sum_All_Daily_Expenses = Sum_All_Daily_Expenses + (double)DataGrid_dayliy_Exp.Rows[i].Cells["Expences_value"].Value;

            }

            Daily_Expencess = Sum_All_Daily_Expenses;

            lb_D_Exp_Value.Text = "-" + Sum_All_Daily_Expenses.ToString() + " " + "$";
        }

        public void Get_All_Daily_Earns()//Get All Daily Eern Function
        {
            double All_Dayily_Earn = Daily_Income - Daily_Expencess;

            lbl_Daily_Earn.Text = All_Dayily_Earn.ToString() + " " + "$";

        }



        public void Get_All_Month_Incomes() //Get All Monthly Income Function
        {

            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            int selected_Month = Edit_Monthe.Month;
            int selected_Year = Convert.ToInt32(comboBoxEdit1.SelectedItem);



            var ob = from p in db.Table_Patients.Where(x => x.Patient_date.Month == selected_Month&&
                     x.Patient_date.Year == selected_Year)

                     select new
                     {
                         p.Patient_name,
                         p.Patient_date,
                         p.paied
                     };


            double Sum_All_Monthly_Income = 0;
            DataGrid_M_Eearn.DataSource = ob;


            for (int i = 0; i < DataGrid_M_Eearn.Rows.Count; i++)
            {
                Sum_All_Monthly_Income = Sum_All_Monthly_Income + (double)DataGrid_M_Eearn.Rows[i].Cells["paied"].Value;

            }
            Monthly_Income = Sum_All_Monthly_Income;

            lb_M_Earn_Value.Text = Sum_All_Monthly_Income.ToString() + " " + "$";

        }


        public void Get_All_Month_Expenses() //Get All Monthly Expencess Function
        {

            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            int selected_Month = Edit_Monthe.Month;
            int selected_Year = Convert.ToInt32(comboBoxEdit1.SelectedItem);



            var ob = from p in db.Table_Expences.Where(x => x.Expences_Date.Month == selected_Month &&
                     x.Expences_Date.Year == selected_Year)

                     select new
                     {
                         p.Expences_Name,
                         p.Expences_value,
                         p.Expences_Date
                     };


            double Sum_All_Yearly_Expenceses = 0;
            DataGrid_Mon_Exp.DataSource = ob;


            for (int i = 0; i < DataGrid_Mon_Exp.Rows.Count; i++)
            {
                Sum_All_Yearly_Expenceses = Sum_All_Yearly_Expenceses + (double)DataGrid_Mon_Exp.Rows[i].Cells["Expences_value"].Value;

            }
            Monthly_Expencess = Sum_All_Yearly_Expenceses;

            lb_M_Exp_Value.Text = "-" + Sum_All_Yearly_Expenceses.ToString() + " " + "$";

        }



        public void Get_All_Montly_Earns()//Get All Montly Eern Function
        {
            double All_Montly_Earn = Monthly_Income - Monthly_Expencess;

            lbl_Monthly_Earn.Text = All_Montly_Earn.ToString() + " " + "$";

        }




        public void Get_All_Year_Incomes() //Get All Year Income Function
        {

            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();

           

            int selected_Year = Convert.ToInt32(comboBoxEdit1.SelectedItem);



            var ob = from p in db.Table_Patients.Where(x => x.Patient_date.Year == selected_Year)

                     select new
                     {
                         p.Patient_name,
                         p.Patient_date,
                         p.paied
                     };


            double Sum_All_Year_Income = 0;
            DataGrid_Ann.DataSource = ob;


            for (int i = 0; i < DataGrid_Ann.Rows.Count; i++)
            {
                Sum_All_Year_Income = Sum_All_Year_Income + (double)DataGrid_Ann.Rows[i].Cells["paied"].Value;

            }
            Yearly_Income = Sum_All_Year_Income;

            lb_Ann_Earn_Value.Text = Sum_All_Year_Income.ToString() + " " + "$";

        }


        public void Get_All_Year_Expencess() //Get All Year ExpencessFunction
        {

            DXL_LINQ.CLS_DXL_IINQDataContext db = new DXL_LINQ.CLS_DXL_IINQDataContext();



            int selected_Year = Convert.ToInt32(comboBoxEdit1.SelectedItem);



            var ob = from p in db.Table_Expences.Where(x => x.Expences_Date.Year == selected_Year)

                     select new
                     {
                         p.Expences_Name,
                         p.Expences_value,
                         p.Expences_Date
                     };


            double Sum_All_Year_Expencess = 0;
            DataGrid_Ann_Exp.DataSource = ob;


            for (int i = 0; i < DataGrid_Ann_Exp.Rows.Count; i++)
            {
                Sum_All_Year_Expencess = Sum_All_Year_Expencess + (double)DataGrid_Ann_Exp.Rows[i].Cells["Expences_value"].Value;

            }
            Yearly_Expencess = Sum_All_Year_Expencess;

            lb_Ann_Exp_Value.Text = "-" + Sum_All_Year_Expencess.ToString() + " " + "$";

        }


        public void Get_All_Year_Earns()//Get All Year Eern Function
        {
            double All_Montly_Earn = Yearly_Income - Yearly_Expencess;

            lbl_Annual.Text = All_Montly_Earn.ToString() + " " + "$";

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
        } // close Button 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit_M_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lb_M_Exp_Value_Click(object sender, EventArgs e)
        {

        }

        private void Errands_Form_Load(object sender, EventArgs e)
        {
            Get_All_Income();// Get All Income Function 

            Get_All_Expencess(); // Get All Expencess Function 

            Get_All_Earn(); //Get All Earn Function

           



        }



        

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {


            Get_All_Dayliy_Income();//Get All Daily Income Function

            GetAll_Daily_Expenses(); //Get All Daily Expendses Function

            Get_All_Daily_Earns();//Get All Daily Eern Function
        }

        private void Edit_Monthe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_All_Month_Incomes(); //Get All Monthly Income Function

            Get_All_Month_Expenses(); //Get All Monthly Expencess Function

            Get_All_Montly_Earns(); //Get All Montly Eern Function
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_All_Month_Incomes(); //Get All Monthly Income Function

            Get_All_Month_Expenses(); //Get All Monthly Expencess Function

            Get_All_Montly_Earns(); //Get All Montly Eern Function


            Get_All_Year_Incomes(); //Get All Year Income Function

            Get_All_Year_Expencess(); //Get All Year ExpencessFunction

            Get_All_Year_Earns();//Get All Year Eern Function
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Home_2_Form f = new Home_2_Form();
            this.Hide();
            f.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Errands_Form_Resize(object sender, EventArgs e)
        {
           
        }
    }
}