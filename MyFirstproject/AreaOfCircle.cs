using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * rad * rad;
            Console.WriteLine($"area of circle is {area}");
        }
    }
}
