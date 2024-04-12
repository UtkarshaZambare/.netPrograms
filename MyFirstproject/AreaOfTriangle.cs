using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base length of the triangle:");
           double  length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle:");
           double height = Convert.ToDouble(Console.ReadLine());

            // Calculate the area
            double area = 0.5 * length * height;

            Console.WriteLine($"The area of the triangle is: {area}");
        }
    }
}
