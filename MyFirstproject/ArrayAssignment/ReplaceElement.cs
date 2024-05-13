using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public class ReplaceElement
    {
        static void ReplaceNegatives(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
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

        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            Console.WriteLine("Original array:");
            PrintArray(arr);

            ReplaceNegatives(arr);

            Console.WriteLine("\nArray after replacing negatives:");
            PrintArray(arr);
        }
    }
}
