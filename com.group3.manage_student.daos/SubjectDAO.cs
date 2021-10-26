using manage_student_app.com.group3.manage_student.dtos;
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
    class SubjectDAO
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
        public DataTable GetAllSubjectsWithMajor(string majorID)
        {
            DataTable ds = new DataTable();          
            try
            {
                con = DBUtils.GetDBConnection();
                if (con != null)
                {
                    con.Open();
                    string sql = "Select MAMH,TENMH,TINCHI from MHOC where MAKH= @majorID";
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@majorID", SqlDbType.VarChar).Value = majorID;
                    adapter.SelectCommand = cmd;                   
                    adapter.Fill(ds);              
                }
                return ds;

            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                close();
            }
            return null;
        
        }

        public DataTable GetSubjectDetailWithSubjectID(string subjectID)
        {                  
            try
            {
                DataTable ds = new DataTable();
                con = DBUtils.GetDBConnection();
                if (con != null)
                {
                    con.Open();
                    string sql = "Select * from MHOC where MAMH= @subjectID";
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@subjectID", SqlDbType.VarChar).Value = subjectID;
                    adapter.SelectCommand = cmd;                   
                    adapter.Fill(ds);                                   
                }
                return ds;
            }
            catch (Exception e)
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
