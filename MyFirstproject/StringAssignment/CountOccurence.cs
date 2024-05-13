using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
   public  class CountOccurence
    {

        public static int CountOccurenceOfChar(string str, char ch) {
            int count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == ch)
                {
                    count++;
                }

               
                }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr string");
            string str = Console.ReadLine();

            Console.WriteLine(" Enter the character you want to count");
            char ch = Console.ReadLine()[0];

            int count = CountOccurenceOfChar(str, ch);
            Console.WriteLine($"The character '{ch}' appears {count} times in the string.");
        }


    }  
    }

