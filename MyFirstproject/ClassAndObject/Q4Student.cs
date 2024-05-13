using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ClassAndObject
{
    public  class Q4Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public override string ToString()
        {
            return $"Roll No: {RollNo}, Name: {Name}, Percentage: {Percentage}%";
        }

        static void Main(string[] args)
        {
            Q4Student student = new Q4Student
            {
                RollNo = 101,
                Name = "Vasu",
                Percentage = 85.5
            };

            Console.WriteLine(student.ToString());
        }
    }
}
