using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dentist_Project.DXL // creat Connection with database Class
{
    
    class CLS_DXL
    {
        
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlConnection cn;
        DataTable dt = new DataTable();

        public CLS_DXL()  // construction to connection  with database it is took same class name 
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-RLS0DE2;Initial Catalog=Dentist_DB;Integrated Security=True"); // sql string connection 
        }

        public void open() // function to open Connection 
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public void close()// function to close Connection 
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        //Read Data from Database
        public DataTable Reader(string sp, SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            da = new SqlDataAdapter(cmd);
            int v= da.Fill(dt);
            return dt;


        }
        //Remove ,Update ,Add,select, insert
        public void RUA(string sp, SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            cmd.ExecuteNonQuery();

        }
    }
}
