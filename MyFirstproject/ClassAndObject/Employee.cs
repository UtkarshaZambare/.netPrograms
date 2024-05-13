using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ClassAndObject
{
    public class Employee
    {
        
        private int id;
        private string name;
        private double basicSalary;
        private double hra;
        private double ta;
        private double pf;

        private static int count = 0;
        private const double PT = 200;

        public double CalculateGrossSalary()
        {

            double grossSalary = basicSalary + hra + ta + pf;
            return grossSalary - PT;

        }

        public Employee(int id, string name, double basicSalary)
        {
            this.id = ++count;
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            hra = (basicSalary * 0.4);
            ta = (basicSalary * 0.2);
            pf = (basicSalary * 0.12);
        }

        public override string ToString()
        {
            return $"Employee Details: ID: {id}\nName: {name}\nBasicSalary: {basicSalary}\nHRA: {hra}\nTA: {ta}\nPF: {pf}\nGrossSalary: {CalculateGrossSalary()}";
        }
        public static void DisplayTotalCount()
        {
            Console.WriteLine($"Total Objects Count: {count}");
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Sanu", 46000.00);

            Console.WriteLine(emp.ToString());

           Employee.DisplayTotalCount();
        }
    }
}
