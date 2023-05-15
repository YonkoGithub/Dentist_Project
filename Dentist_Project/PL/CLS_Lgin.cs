using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dentist_Project.DXL;
namespace Dentist_Project.PL
{
    class CLS_Lgin // Login Class
    {

        public DataTable S_login(string username,string passwrd,string tyeap) //login Functio
        {

            CLS_DXL ob = new CLS_DXL();
            DataTable dt = new DataTable(); // it will stored all tables in database tables in dt
            SqlParameter[] p = new SqlParameter[3];  // SqlPArammiter Array  to stored all Data from Database
            p[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            p[0].Value = username;
            p[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            p[1].Value = passwrd;
            p[2] = new SqlParameter("@user_type", SqlDbType.NVarChar, 50);
            p[2].Value = tyeap;
            ob.open();// to open connection with database during CLS_DXL Class
            dt = ob.Reader("S_login", p);
            ob.close();
            return dt;
        }  
    }
}
