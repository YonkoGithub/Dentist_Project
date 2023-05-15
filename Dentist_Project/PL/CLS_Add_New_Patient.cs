using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;





namespace Dentist_Project.PL   //Add New Patient State Class to add New State from New Patient State form and stored in  the  Database
{
    class CLS_Add_New_Patient
    {

        public void add_new_state(string New_State) // function to add New State from New Patient State Form and stored in the Database
        {

            Dentist_Project.DXL.CLS_DXL ob = new DXL.CLS_DXL(); // Call again Class_CLS_DXL this Class  opened and Closed  Connection with Database
            ob.open(); // opened Connection
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@state_name", SqlDbType.NVarChar);
            p[0].Value = New_State;

            ob.RUA("add_state", p);
            ob.close();


        }

        public DataTable view_patient_state()   // function to  bring Data from Database andPrint it in the Combo Bo
        {
            DataTable dt = new DataTable();
            Dentist_Project.DXL.CLS_DXL ob = new DXL.CLS_DXL(); // Call again Class_CLS_DXL this Class  opened and Closed  Connection with Database
            ob.open(); // opened Connection

            dt = ob.Reader("view_patient_state", null);
            ob.close();
            return dt;
        }

        //Add New Patient  function  to add New Patient from Add New Patient Form and stored in  the  Database
        public void Add_New_patient(int PAT_ID,string PAT_TC,string PAT_NAME, int PAT_AGE,
            string PAT_GENDER,string PAT_PHONE,DateTime DATE,
            string PAT_EMAIL,double PAT_COST,double PAT_PAIED,double PAT_REMIND,
            byte[] PAT_IMAGE,string PAT_STATE)
        {
            Dentist_Project.DXL.CLS_DXL ob = new DXL.CLS_DXL();  // Call again Class_CLS_DXL this Class  opened and Closed  Connection with Databas
            ob.open();

            SqlParameter[] p = new SqlParameter[13];
            p[0] = new SqlParameter("@Patient_id", SqlDbType.Int);
            p[0].Value = PAT_ID;
            p[1] = new SqlParameter("@Patient_tc", SqlDbType.NVarChar, 50);
            p[1].Value = PAT_TC;
            p[2] = new SqlParameter("@Patient_name", SqlDbType.NVarChar, 50);
            p[2].Value = PAT_NAME;
            p[3] = new SqlParameter("@Patient_age", SqlDbType.Int);
            p[3].Value = PAT_AGE;
            p[4] = new SqlParameter("@Patient_gender", SqlDbType.NVarChar, 50);
            p[4].Value = PAT_GENDER;
            p[5] = new SqlParameter("@Patient_phone", SqlDbType.NVarChar, 50);
            p[5].Value = PAT_PHONE;
            p[6] = new SqlParameter("@Patient_date", SqlDbType.Date);
            p[6].Value = DATE;
            p[7] = new SqlParameter("@Patient_email", SqlDbType.NVarChar, 50);
            p[7].Value = PAT_EMAIL;
            p[8] = new SqlParameter("@cost", SqlDbType.Float);
            p[8].Value = PAT_COST;
            p[9] = new SqlParameter("@paied", SqlDbType.Float);
            p[9].Value = PAT_PAIED;
            p[10] = new SqlParameter("@remind", SqlDbType.Float);
            p[10].Value = PAT_REMIND;
            p[11] = new SqlParameter("@Patient_img", SqlDbType.Image);
            p[11].Value = PAT_IMAGE;
            p[12] = new SqlParameter("@Patient_state", SqlDbType.NVarChar, 50);
            p[12].Value = PAT_STATE;

            ob.RUA("new_Patient", p);
            ob.close();
        }

        public DataTable Show_Patient_ID() // Red Patient ID Number fom Datbase Table  function 
        {
            DataTable dt = new DataTable();
            DXL.CLS_DXL ob = new DXL.CLS_DXL();
            ob.open();
           
             dt = ob.Reader("Show_Patient_ID", null); // Sql Procdure Name
            ob.close();
            return dt;
        }

        public DataTable View_All_Patient() // Diesplay all Patient Data on Patient Manegment Form 
        {
            DataTable dt = new DataTable();
            DXL.CLS_DXL ob = new DXL.CLS_DXL();
            ob.open();
            dt = ob.Reader("View_All_Patient", null);
            ob.close();
            return dt;
        }



        public DataTable Search_Patient_info(string PAT_ID) // Search Patient Info Function
        {
            DataTable dt = new DataTable();
            DXL.CLS_DXL ob = new DXL.CLS_DXL();
            ob.open();

            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@Patient_id", SqlDbType.NVarChar,50);
            p[0].Value = PAT_ID;

            dt = ob.Reader("Search_Patient_Info", p);
            ob.close();
            return dt;
            

        }

        //Update  Patient Info   function 
        public void Update_New_patient(int PAT_ID, string PAT_TC, string PAT_NAME, int PAT_AGE,
            string PAT_GENDER, string PAT_PHONE, DateTime DATE,
            string PAT_EMAIL, double PAT_COST, double PAT_PAIED, double PAT_REMIND,
            byte[] PAT_IMAGE, string PAT_STATE)  //Update  Patient Info   function 
        {
            Dentist_Project.DXL.CLS_DXL ob = new DXL.CLS_DXL();  // Call again Class_CLS_DXL this Class  opened and Closed  Connection with Databas
            ob.open();

            SqlParameter[] p = new SqlParameter[13];
            p[0] = new SqlParameter("@Patient_id", SqlDbType.Int);
            p[0].Value = PAT_ID;
            p[1] = new SqlParameter("@Patient_tc", SqlDbType.NVarChar, 50);
            p[1].Value = PAT_TC;
            p[2] = new SqlParameter("@Patient_name", SqlDbType.NVarChar, 50);
            p[2].Value = PAT_NAME;
            p[3] = new SqlParameter("@Patient_age", SqlDbType.Int);
            p[3].Value = PAT_AGE;
            p[4] = new SqlParameter("@Patient_gender", SqlDbType.NVarChar, 50);
            p[4].Value = PAT_GENDER;
            p[5] = new SqlParameter("@Patient_phone", SqlDbType.NVarChar, 50);
            p[5].Value = PAT_PHONE;
            p[6] = new SqlParameter("@Patient_date", SqlDbType.Date);
            p[6].Value = DATE;
            p[7] = new SqlParameter("@Patient_email", SqlDbType.NVarChar, 50);
            p[7].Value = PAT_EMAIL;
            p[8] = new SqlParameter("@cost", SqlDbType.Float);
            p[8].Value = PAT_COST;
            p[9] = new SqlParameter("@paied", SqlDbType.Float);
            p[9].Value = PAT_PAIED;
            p[10] = new SqlParameter("@remind", SqlDbType.Float);
            p[10].Value = PAT_REMIND;
            p[11] = new SqlParameter("@Patient_img", SqlDbType.Image);
            p[11].Value = PAT_IMAGE;
            p[12] = new SqlParameter("@Patient_state", SqlDbType.NVarChar, 50);
            p[12].Value = PAT_STATE;

            ob.RUA("update_patients_info", p);
            ob.close();
        }


        public void Delete_Patient_Info(int PAT_ID) // Patient Delte function
        {
            DXL.CLS_DXL ob = new DXL.CLS_DXL();
           
            ob.open();
            
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("Patient_ID", SqlDbType.Int);
            p[0].Value = PAT_ID;
            ob.RUA("Delete_Patient_Info", p);
            ob.close();
        }



        public DataTable Show_patient_Name() // Red Patient Name  fom Datbase Table  function 
        {
            DataTable dt = new DataTable();
            DXL.CLS_DXL ob = new DXL.CLS_DXL();
            ob.open();
            dt = ob.Reader("Show_patient_Name", null); // Sql Procdure Name
            ob.close();
            return dt;
        }


    }
}


