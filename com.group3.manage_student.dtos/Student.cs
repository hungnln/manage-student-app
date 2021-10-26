using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_student_app.com.group3.manage_student.dtos
{
    class Student
    {
        private int id;
        private string name;
        private string birthdate;
        private Major major;

        public Student(int id, string name, string birthdate, Major major)
        {
            this.id = id;
            this.name = name;
            this.birthdate = birthdate;
            this.major = major;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        internal Major Major { get => major; set => major = value; }
    }
}
