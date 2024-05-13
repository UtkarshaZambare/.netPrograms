using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
   public class AvrageOfArray
    {

        public static int Average(int[] arr) {

            if (arr.Length == 0)
                return 0;
            int sum = 0;
            foreach (int num in arr) {

                sum = sum + num;
            }
            return sum / arr.Length;
        }


        public static double Average(double[] arr) {

            if (arr.Length == 0.0)
                return 0;

            double sum = 0.0;

            foreach (double num in arr) {
                sum = sum + num;
            
            }
            return sum / arr.Length;

        }

        static void Main(string[] args)
        {
            int[] iarr = { 2, 4, 6, 8, 10 };
            double[] darr = { 1.5, 2.5, 3.5, 4.5, 5.5 };

            Console.WriteLine("Average of int array: " + Average(iarr));
            Console.WriteLine("Average of double array: " + Average(darr));
        }
    }
}
