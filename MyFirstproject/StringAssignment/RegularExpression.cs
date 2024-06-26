﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyFirstproject.StringAssignment
{
    public class RegularExpression
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d{10}$";

            Console.WriteLine("Enter Number : ");
            string mobNum = Console.ReadLine();

            bool isValidMobileNumber = Regex.IsMatch(mobNum, pattern);

            if (isValidMobileNumber)
            {
                Console.WriteLine("Valid mobile number...");
            }
            else
            {
                Console.WriteLine("Invalid mobile number...");
            }


        }
    }
}
