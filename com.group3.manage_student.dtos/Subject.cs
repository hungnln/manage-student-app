using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_student_app.com.group3.manage_student.dtos
{
    class Subject
    {
        private string subjectID;
        private string subjectName;
        private int credits;
        private Major major;

        public Subject(string subjectID, string subjectName, int credits, Major major)
        {
            this.SubjectID = subjectID;
            this.SubjectName = subjectName;
            this.Credits = credits;
            this.Major = major;
        }

        public string SubjectID { get => subjectID; set => subjectID = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public int Credits { get => credits; set => credits = value; }
        internal Major Major { get => major; set => major = value; }
    }
}
