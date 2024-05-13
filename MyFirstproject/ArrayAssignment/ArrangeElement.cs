using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public class ArrangeElement
    {
        static void ArrangeArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                if (arr[left] < 0)
                {
                    left++;
                }
                else if (arr[right] >= 0)
                {
                    right--;
                }
                else
                {
                    
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
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
            int[] array = { 7, -2, 3, -8, 5, -6, 0, 4, -1 };

            Console.WriteLine("Original Array:");
            PrintArray(array);

            ArrangeArray(array);

            Console.WriteLine("\nArray after arranging negative Elements before positive Elements:");
            PrintArray(array);
        }
    }
}
