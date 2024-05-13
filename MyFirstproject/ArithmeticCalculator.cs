using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
   public class ArithmeticCalculator
    {

        // Addition
        public static int Calculate(int a, int b)
        {
            return a + b;
        }

        // Subtraction
        public static int Calculate(int a, int b, bool subtract)
        {
            if (subtract)
                return a - b;
            else
                return Calculate(a, b);
        }

        // Multiplication
        public static int Calculate(int a, int b, char operatorSymbol)
        {
            if (operatorSymbol == '*')
                return a * b;
            else
                return Calculate(a, b, '-');
        }

        // Division
        public static double Calculate(int  a, int  b, string operatorSymbol)
        {
            if (operatorSymbol == "/")
                return a / b;
            else
                return Calculate(a, b, '*');
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Addition: " + Calculate(5, 3));
            Console.WriteLine("Subtraction: " + Calculate(5, 3, true));
            Console.WriteLine("Multiplication: " + Calculate(5, 3, '*'));
            Console.WriteLine("Division: " + Calculate(5, 3, "/"));
        }
    }
}
