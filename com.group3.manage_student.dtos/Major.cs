using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_student_app.com.group3.manage_student.dtos
{
    class Major
    {
        private String majorID;
        private String majorName;
        private int foundedYear;

        public Major(string majorID, string majorName, int foundedYear)
        {
            this.majorID = majorID;
            this.majorName = majorName;
            this.foundedYear = foundedYear;
        }

        public string MajorID { get => majorID; set => majorID = value; }
        public string MajorName { get => majorName; set => majorName = value; }
        public int FoundedYear { get => foundedYear; set => foundedYear = value; }
    }

}
