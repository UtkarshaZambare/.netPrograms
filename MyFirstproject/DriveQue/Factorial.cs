using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.DriveQue
{
    public  class Factorial
    {
        public static void FindFactorial(int num) {

            for (int i = num - 1; i >= 1; i--) {
                num = num * i;
            }

            Console.WriteLine("Factorial is:"+num);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Factorial.FindFactorial(num);
        }
    }
}
