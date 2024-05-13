using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class SearchElement
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 3, 7, 8, 9 };

            int searchNumber = 3;

            int index = Array.IndexOf(numbers, searchNumber);

            if (index != -1)
            {
                Console.WriteLine($"Element {searchNumber} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element {searchNumber} not found in the array.");
            }
        }
    }
}
