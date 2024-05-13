using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    public  class CountWords
    {
        static int FindCountWords(string input)
        {
            int wordCount = 0;
            bool inWord = false;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        wordCount++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }

            
            if (inWord)
            {
                wordCount++;
            }

            return wordCount;
        }
        static void Main(string[] args)
        {
            string inputString;
            Console.WriteLine("Enter a string:");
            inputString = Console.ReadLine();

            int wordCount = FindCountWords(inputString);
            Console.WriteLine($"Total number of words: {wordCount}");
        }
    }
}
