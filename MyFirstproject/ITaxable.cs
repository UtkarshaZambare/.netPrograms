using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
     public interface ITaxable
    {
        double PayTax();
    }

    public class Job : ITaxable 
    {
        private double salary;
        private double taxamount;

        public Job()
        {
            salary = 10000;
        }

        public double PayTax() {

            taxamount = salary * 0.20;
            return taxamount;
        
        }
    }

        /*public class Business : ITaxable {

            public Business() {
                salary = 10000;
            }


            public double PayTax()
            {

                taxamount = salary * 0.20;
                return taxamount;

            }
        }*/

}
