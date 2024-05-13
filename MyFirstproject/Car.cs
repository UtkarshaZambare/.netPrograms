using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class Car
    {

        public static string manufacturer = "Toyota";

        
        public string model;
        public int year;

      
        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
            Console.WriteLine($"A new {manufacturer} {model} ({year}) has been created.");
        }

       
        public static void CarInfo()
        {
            Console.WriteLine($"This is a {manufacturer} car.");
        }

        
        public void Drive()
        {
            Console.WriteLine($"Driving {manufacturer} {model} ({year}).");
        }
    }
}
