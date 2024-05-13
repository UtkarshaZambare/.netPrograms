using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
  public  class Shopping
    {

        private int productId;
        private string productName;
        private double price;
        private int quantity;
        private double totalBill;

        public void AddProduct(int productId, string productName, double price, int quantity) {

            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;

        }
        public void CalculateTotalBill()
        {
            if (quantity > 0)
            {
                totalBill = price * quantity;
            }
            else
            {
                Console.WriteLine("Error: Quantity should be greater than 0.");
            }

           
        }
        public string  ShowDetail()
        {

            return ($"Product ID: {productId}, Product Name: {productName}, Price: {price}, Quantity: {quantity} , TotalBill :{totalBill}");
        }
    }
    }


   

