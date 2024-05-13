using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
   public class EvenOdd
    {

        static void SplitEvenOdd(int[] originalArray, out int[] evenArray, out int[] oddArray)
        {
            int evenCount = 0;
            int oddCount = 0;

            
            foreach (int num in originalArray)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            
            evenArray = new int[evenCount];
            oddArray = new int[oddCount];

           
            int evenIndex = 0;
            int oddIndex = 0;
            foreach (int num in originalArray)
            {
                if (num % 2 == 0)
                {
                    evenArray[evenIndex] = num;
                    evenIndex++;
                }
                else
                {
                    oddArray[oddIndex] = num;
                    oddIndex++;
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] originalArray = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evenArray, oddArray;

            SplitEvenOdd(originalArray, out evenArray, out oddArray);

            Console.WriteLine("Even elements:");
            PrintArray(evenArray);

            Console.WriteLine("\nOdd elements:");
            PrintArray(oddArray);
        }

    }
}
