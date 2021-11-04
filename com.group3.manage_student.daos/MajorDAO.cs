using manage_student_app.com.group3.manage_student.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_student_app.com.group3.manage_student.daos
{
    class MajorDAO
    {
        private SqlConnection con;           
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();

        private void close()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
        public DataTable getAllMajors()
        {           
            try
            {
                con = DBUtils.GetDBConnection();
                if (con != null)
                {
                    con.Open();
                    string sql = "Select MAKHOA,TENKHOA,NAMTHANHLAP from KHOA";
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    adapter.SelectCommand = cmd;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    return ds;                    
                }
            }catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                close();
            }
            return null;
        }       
    }
}
