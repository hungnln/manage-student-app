using manage_student_app.com.group3.manage_student.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_student_app.com.group3.manage_student.daos
{

    class StudentDAO
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
        public DataTable GetAllStudentWithValidSubject(string subjectID)
        {            
            try
            {
                con = DBUtils.GetDBConnection();
                if (con != null)
                {
                    con.Open();
                    string sql = @"Select SVIEN.TEN,SVIEN.MASV,SVIEN.NGAYSINH,KQUA.DIEM 
                                   from ((KQUA inner join HPHAN on KQUA.MAHP = HPHAN.MAHP)
                                   join SVIEN on KQUA.MASV = SVIEN.MASV)
                                   where HPHAN.MAMH = @subjectID";
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@subjectID", SqlDbType.VarChar).Value = subjectID;
                    adapter.SelectCommand = cmd;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    return ds;
                }
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
