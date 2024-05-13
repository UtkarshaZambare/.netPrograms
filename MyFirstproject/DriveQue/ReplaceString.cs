using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.DriveQue
{
    public  class ReplaceString
    {
        static string ReplaceLetter(string input, char oldch,char newch ) {

            char[] ch = input.ToCharArray();

            for (int i = 0; i < ch.Length; i++) {

                if (ch[i] == oldch)
                {
                    ch[i] = newch;
                }
            }

            return new string(ch);
        
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Write a string:");
            string input  = Console.ReadLine();

            Console.WriteLine("Write a char you want to replace:");
            char oldch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Write a char you want to replace with:");
            char newch = Convert.ToChar(Console.ReadLine());

            string resultString = ReplaceLetter(input, oldch, newch);
            Console.WriteLine($"Result string after replacement: {resultString}");
        }
    }
}
