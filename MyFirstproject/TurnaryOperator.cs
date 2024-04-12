using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class TurnaryOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number > 0) ? "Positive" : (number < 0) ? "Negative" : "Zero";

            Console.WriteLine($"number is {result}"); 
        
        }

        }
    }

