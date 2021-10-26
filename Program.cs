using manage_student_app.com.group3.manage_student.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_student_app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentManagementApplication());
            /*StudentDAO student = new StudentDAO();
            Console.WriteLine(student.GetStudentWithStudentID(1).Name);*/
            
        }
    }
}
