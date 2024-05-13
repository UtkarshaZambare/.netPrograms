﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    internal class ReverseOrderOfWords
    {
        static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');

            string revStr = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                revStr += words[i];

                if (i > 0)
                {
                    revStr += " ";
                }
            }
            return revStr;
        }

        static void Main(string[] args)
        {
            string str = "reverse order of words in a given string";

            string revStr = ReverseWords(str);

            Console.WriteLine("Original String : " + str);

            Console.WriteLine();

            Console.WriteLine("String with reverse order of words : " + revStr);
        }
    }
}
 
