using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public  class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine("Original array:");
            PrintArray(arr);

            ReverseArrays(arr);

            Console.WriteLine("\nReversed array:");
            PrintArray(arr);
        }

        static void ReverseArrays(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
               
                arr[start] ^= arr[end];
                arr[end] ^= arr[start];
                arr[start] ^= arr[end];

                
                start++;
                end--;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
