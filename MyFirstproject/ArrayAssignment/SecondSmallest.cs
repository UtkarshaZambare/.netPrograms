using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public  class SecondSmallest
    {

        public static int FindSecondSmallest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements");
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            return secondSmallest;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 3, 2, 5, 6, 7, 6 };
            int secondSmallest = FindSecondSmallest(arr);
            Console.WriteLine("The second smallest element in the array is: " + secondSmallest);
        }
    }
}

