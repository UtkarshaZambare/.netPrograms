using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class MergArrays
    {
       

      static int[] MergeArrays(int[] array1, int[] array2)
        {
            
            int length = array1.Length + array2.Length;

            
            int[] mergedArray = new int[length];

            
            for (int i = 0; i < array1.Length; i++)
            {
                mergedArray[i] = array1[i];
            }

            
            for (int i = 0; i < array2.Length; i++)
            {
                mergedArray[array1.Length + i] = array2[i];
            }

            return mergedArray;
        }

        static void Main(string[] args)
        {

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };


            int[] mergedArray = MergeArrays(array1, array2);


            Console.WriteLine("Merged Array:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
