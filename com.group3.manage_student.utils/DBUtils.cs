using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_student_app.com.group3.manage_student.utils
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = "DESKTOP-PL1AB0Q";
            string database = "QLSVien";
            string username = "sa";
            string password = "12345678";
            string connectString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connectString);
            return conn;
        }

    }
}
