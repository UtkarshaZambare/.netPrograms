using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public  class NegativeNumber
    {

        public static void PrintNegativeNumber(int[] arr) {
            foreach (int num in arr) {
                if (num < 0) {
                    Console.WriteLine(num);
                
                }
            }
        
        }

        public static int CountOfNegativeNumber(int[]arr) {
            int count =0;
            foreach (int num in arr) {
                if (num < 0) {
                    count++;
                
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, -3, 5, -7, 8, -10, 12, -15 };

            Console.WriteLine("Negative elements in the array:");
            PrintNegativeNumber(arr);

            int negativeCount = CountOfNegativeNumber(arr);
            Console.WriteLine("Total number of negative elements: " + negativeCount);
        }

    }
}
