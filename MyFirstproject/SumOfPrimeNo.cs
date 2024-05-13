using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public class SumOfPrimeNo
    {
        static bool IsPrime(int num) {

            if (num <= 1)
                return false;
            for (int i = 2; i *i<= num; i++) {

                if (num % i == 0)
                    return false;

            }
            return true;
        }

         static int SumOfPrimes(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    sum += num;
                }
            }
            return sum;
        }
       static void Main(string[] args) {

            int[] arr = { 3, 7, 12, 5, 16, 11 };

            int sum = SumOfPrimes(arr);

            Console.WriteLine("Sum of prime numbers in the array: " + sum);
        }

    }
}
