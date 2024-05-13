using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
   public  class ReverseString
    {
        static string ReverseStrings(string str)
        {
            string revStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }
            return revStr;
        }
        static void Main(string[] args)
        {

            string str = "Good Morning";
            Console.WriteLine("Original String :");
            Console.WriteLine(str);

            Console.WriteLine();

            Console.WriteLine("Original String :");
            Console.WriteLine(ReverseStrings(str));

        }
    }
}
