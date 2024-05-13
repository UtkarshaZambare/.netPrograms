using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    public class FindDuplicateWordsTheirNumOfOccurence
    {
        static void FindDuplicateWords(string input)
        {
            
            string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            
            foreach (string word in words)
            {
               
                string lowercaseWord = word.ToLower();

                
                if (wordCount.ContainsKey(lowercaseWord))
                {
                    wordCount[lowercaseWord]++;
                }
                
                else
                {
                    wordCount.Add(lowercaseWord, 1);
                }
            }

           
            Console.WriteLine("Duplicate words and their number of occurrences:");
            foreach (var pair in wordCount.Where(pair => pair.Value > 1))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        static void Main()
        {
            string inputString = "Write a C# program to find the duplicate words in a string and their number of occurrences";
            FindDuplicateWords(inputString);
        }
    }
}
