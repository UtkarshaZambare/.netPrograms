using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public class UniqueElements
    {
        public static void PrintUniqueElements(int[] arr)
        {
            bool isUnique;

            Console.WriteLine("Unique elements in the array:");

            for (int i = 0; i < arr.Length; i++)
            {
                isUnique = true;

                // Check if arr[i] is unique
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                // If arr[i] is unique, print it
                if (isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 3, 2, 5, 6, 7, 6 };
            PrintUniqueElements(arr);
        }

    }
}
