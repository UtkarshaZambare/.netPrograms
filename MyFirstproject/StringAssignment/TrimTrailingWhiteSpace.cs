using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    internal class TrimTrailingWhiteSpace
    {
        static void Main(string[] args)
        {
            string str = "   India     ";
            Console.WriteLine("Original String : " + str);
            Console.WriteLine();

            Console.WriteLine("String After Trim : ");
            Console.WriteLine(str.TrimEnd());
        }
    }
}
