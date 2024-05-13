using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    internal class SplitString
    {
        public static void SplitStrings(string str)
        {
            string[] st = str.Split("$");

            foreach (string s in st)
            {
                Console.Write(s + " ");
            }
        }
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";

            SplitStrings(str);
        }
    }
}
