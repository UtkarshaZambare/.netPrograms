﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class DisplayNumber
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to pune");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(" Pune");
                }
                else if (i % 5 == 0)
                {

                    Console.WriteLine("Welcome ");
                }

                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
