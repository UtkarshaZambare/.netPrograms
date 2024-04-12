using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public class SwapTwoNumber
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"num1={num1} num2={num2}");
        }
    }
}
