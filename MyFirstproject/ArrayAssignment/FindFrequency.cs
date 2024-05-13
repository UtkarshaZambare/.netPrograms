using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
   public  class FindFrequency
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 3, 2, 5, 6, 7, 6 };

            Console.WriteLine("Frequency of each element in the array:");

            
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] == int.MinValue)
                {
                    continue;
                }

                int count = 1; 
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        count++; 
                        array[j] = int.MinValue; 
                    }
                }

                
                Console.WriteLine($"Element {array[i]}: {count} times");
            }
        }
    }
}
