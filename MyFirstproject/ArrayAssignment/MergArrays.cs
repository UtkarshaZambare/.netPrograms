using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
   public  class MergArrays
    {

        //10.  WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
        static void Main()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 4, 6, 8, 10 };
            int maxLength = array1.Length + array2.Length;
            int[] mergedArray = new int[maxLength];
            int mergedIndex = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < mergedIndex; j++)
                {
                    if (array1[i] == mergedArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    mergedArray[mergedIndex] = array1[i];
                    mergedIndex++;
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < mergedIndex; j++)
                {
                    if (array2[i] == mergedArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    mergedArray[mergedIndex] = array2[i];
                    mergedIndex++;
                }
            }

            Array.Resize(ref mergedArray, mergedIndex);

            Console.WriteLine("Merged Array:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}

