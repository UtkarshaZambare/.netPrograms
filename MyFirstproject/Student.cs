using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
   public  class Student
    {
        private int rollno;
        private string name;

        public Student()
        {
            rollno = 101;
            name = "Mona";
        }

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
            
        }

        public string Display() {

            return $"rollno {rollno}, name {name}";
        }
    }
}
