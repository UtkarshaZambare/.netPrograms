using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
  public  class SwapTwoStringsWithoutThird
    {

        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";

            Console.WriteLine($"Before Swaping: a = {a}, b = {b}");

            a = a + b;
            b = a.Substring(0, a.Length - b.Length);
            a = a.Substring(b.Length);

            Console.WriteLine($"After Swaping: a = {a}, b = {b}");

        }
    }
}
