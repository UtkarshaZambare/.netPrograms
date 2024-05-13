using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class CalculateArea
    {

        public static double CalculateAreas(double length, double width)
        {
            return length * width;
        }

        public static double CalculateAreas(int baseLength, int height)
        {
            return 0.5 * baseLength * height;
        }

        public static double CalculateAreas(double radius)
        {
            return Math.PI * radius * radius;
        }

        static void Main(string[] args)
        {
            char Choice;

            do
            {
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Triangle ");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                Choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (Choice)
                {
                    case '1':
                        Console.Write("Enter length of rectangle: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter width of rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of rectangle: " + CalculateAreas(length, width));
                        break;

                    case '2':
                        Console.WriteLine("Enter base length of triangle:");
                        int baseLength = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter height  of triangle:");
                        int height = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Area of triangle: " + CalculateAreas(baseLength, height));
                        break;

                    case '3':
                        Console.WriteLine("Enter radius of circle:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of circle: " + CalculateAreas(radius));
                        break;
                    case '4':
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
                Console.WriteLine();
            } while (Choice != '4');
        }
    }
}