using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    internal class ReverseStringWithPreservingSpacesPosition
    {
        static string ReverseStringPreservingSpaces(string str)
        {

            char[] chars = str.ToCharArray();
            int length = chars.Length;
            char[] reservedCahr = new char[length];
            int j = length - 1;

            for (int i = 0; i < length; i++)
            {
                if (chars[i] == ' ')
                {
                    reservedCahr[i] = ' ';
                }
                else
                {
                    while (j >= 0 && chars[j] == ' ')
                    {
                        j--;
                    }
                    reservedCahr[j] = chars[i];
                    j--;
                }
            }
            return new string(reservedCahr);
        }
        static void Main(string[] args)
        {
            string str = "program to reverse a given string with preserving";

            string reversedString = ReverseStringPreservingSpaces(str);
            Console.WriteLine(reversedString);
        }
    }
}
