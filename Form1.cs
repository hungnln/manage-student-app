using manage_student_app.com.group3.manage_student.daos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_student_app
{
    public partial class StudentManagementApplication : Form
    {
        public StudentManagementApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentDAO student = new StudentDAO();
            MajorDAO major = new MajorDAO();
            cbMajor.DataSource = major.getAllMajors();
            cbMajor.DisplayMember = "TENKHOA";
            cbMajor.ValueMember = "MAKHOA";          
        }

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cbSubject.DataSource = null;
            txtCredits.Text = null;
            txtSubjectName.Text = null;
            dataGridView.DataSource = null;
            
            SubjectDAO subjectDAO = new SubjectDAO();
            DataTable data = subjectDAO.GetAllSubjectsWithMajor(cbMajor.SelectedValue.ToString());
            cbSubject.DataSource = data;
            cbSubject.DisplayMember = "MAMH";
            cbSubject.ValueMember = "MAMH";                    
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {         
            if(cbSubject.DataSource != null) {
                SubjectDAO subjectDAO = new SubjectDAO();
                DataTable data = subjectDAO.GetSubjectDetailWithSubjectID(cbSubject.SelectedValue.ToString());
                foreach (DataRow row in data.Rows)
                {
                    txtCredits.Text = row["TINCHI"].ToString();
                    txtSubjectName.Text = row["TENMH"].ToString();
                }
                StudentDAO studentDAO = new StudentDAO();
                DataTable data2 = studentDAO.GetAllStudentWithValidSubject(cbSubject.SelectedValue.ToString());
                dataGridView.DataSource = data2;
            }
            
        }

        
    }
}
