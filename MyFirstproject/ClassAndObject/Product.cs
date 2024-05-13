using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject.ClassAndObject
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public override string ToString()
        {
            return $"ProductId: {ProductID}, ProductName: {ProductName}, ProductPrice: {ProductPrice}";
        }

        public void ApplyDiscount(double discPer)
        {
            double discAmount = ProductPrice * (discPer / 100);
            double discPrice = ProductPrice - discAmount;

            Console.WriteLine($"Actual Price  : {ProductPrice}");
            Console.WriteLine($"Discount Price: {discPer}% off : {discPrice}");
        }

        static void Main(string[] args)
        {
            Product product = new Product
            {
                ProductID = 101,
                ProductName = "Laptop",
                ProductPrice = 30000
            };

            Console.WriteLine(product.ToString());

            Console.WriteLine("***************************************");

            Console.WriteLine("Enter Discount Percentage: ");
            double discPer = Convert.ToDouble(Console.ReadLine());

            product.ApplyDiscount(discPer);
        }
    }
}
