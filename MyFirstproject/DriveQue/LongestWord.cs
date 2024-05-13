using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.DriveQue
{
    public  class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers of strings");
            int n = int.Parse(Console.ReadLine());

            string[] str = new string[n];
            Console.WriteLine("Enter the strings");

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            for (int i = 0; i < str.Length; i++) {
                string temp = "";
                for (int j = 0; j < str.Length; j++) {
                    if (str[i].Length < str[j].Length) {

                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    
                    }
                
                }
            }

            Console.WriteLine("Longest string: " + str[str.Length - 1]);
        }
    }
}
