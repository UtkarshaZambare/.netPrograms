using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public  class SortArray
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 8, 1, 3, 6 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("\nSorted array in ascending order:");
            PrintArray(array);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        swapped = true;
                    }
                }

                
                n--;
            } while (swapped);
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

