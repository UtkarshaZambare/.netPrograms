using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class GreadPercentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter sub1 marks");
            int sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter sub2 marks");
            int sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter sub3 marks");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter sub4marks");
            int sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter sub5 marks");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            double totalmarks = sub1 + sub2 + sub3 + sub4 + sub5;

            double per = (totalmarks / (5 * 100)) * 100;

            Console.WriteLine($"percentage:{per}%");

            string grade;

            if (per >= 90)
            {
                grade = "A";
            }

            else if (per >= 80) {
                grade = "B";
            }

            else if (per >=70)
            {
                grade = "C";
            }

            else if (per >= 60)
            {
                grade = "D";
            }

            else if (per >= 50)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }

            
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
