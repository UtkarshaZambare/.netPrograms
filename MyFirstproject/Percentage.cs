using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
   public  class Percentage
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

            
        }
    }
}
