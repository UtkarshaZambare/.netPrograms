using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyFirstproject.StringAssignment
{
    public class FindOccurence
    {

        static int FindFirstOccurrence(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");

            string str = Console.ReadLine();

            Console.WriteLine("Enter char you want to find ");
            char ch = Console.ReadLine()[0];

            int index = FindFirstOccurrence(str, ch);

            if (index != -1)
            {
                Console.WriteLine($"The first occurrence of '{ch}' is at index: {index}");
            }
            else
            {
                Console.WriteLine($"The character '{ch}' is not found in the string.");
            }


        }
    }

}
    

