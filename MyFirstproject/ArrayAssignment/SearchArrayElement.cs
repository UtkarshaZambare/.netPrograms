using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ArrayAssignment
{
    public  class SearchArrayElement
    {
        static void Main(string[] args) {

            int[] arr = { 10, 20, 30, 40, 50, 60 };

            int srch = 10;

            int res = Array.IndexOf(arr, srch);

            if (res != -1)
            {

                Console.WriteLine($"Element {srch} is present at index {res}");
            }
            else {

                Console.WriteLine($"Element {srch} is not present in the array");
            }
        
        }

    }
}
