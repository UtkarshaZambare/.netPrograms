using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.DriveQue
{
    public class PalindromNo
    {
        static bool IsPalindrome(int number)
        {
            int reversedNumber = 0;
            int originalNumber = number;

            // Reverse the number
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            // Check if the reversed number is equal to the original number
            return originalNumber == reversedNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine(number + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(number + " is not a palindrome.");
            }
        }

    }
}