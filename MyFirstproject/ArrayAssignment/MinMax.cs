using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
   public  class MinMax
    {
        static int FindMaximum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int FindMinimum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 10, 5, 8, 3, 6 };

            int max = FindMaximum(array);
            int min = FindMinimum(array);

            Console.WriteLine("Maximum value in the array: " + max);
            Console.WriteLine("Minimum value in the array: " + min);
        }
    }
}
