using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    public  class LongestWordInSentence
    {

        static string LongestWordLength(string str)
        {
            string[] words = str.Split(' ');
            int length = 0;
            string longestWord = "";


            for (int i = 0; i < words.Length; i++)
            {
                if (length < words[i].Length)
                {
                    longestWord = words[i];
                }
            }

            return longestWord;
        }
        static void Main(string[] args)
        {

            string str = "find longest word in the given sentence";

            Console.Write("Longest wotd in given sentence is : " + LongestWordLength(str));

        }
    }
}
