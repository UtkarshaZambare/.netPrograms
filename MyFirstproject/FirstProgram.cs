using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public class FirstProgram
    {
        static void Main(string[] args) {

            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter num 2");

            int num2 = Convert.ToInt32(Console.ReadLine());

            int c = num1 + num2;
            Console.WriteLine($"addition is {c}");
        }

      
    }
    
}

