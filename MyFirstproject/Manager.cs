using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class Manager : Employee
    {
        private double food;

        public Manager() : base() { 
        
        }

        public Manager(int id, string name, double b,double h,double p, double food):base(id,name,b,h,p)
        {
            this.food = food;
        }

        public override void CalculateSalary()
        {
            gross = (bs + hra + food) - pf;
        }

        public override string Display()
        {
            return $" manager salary :empid {empid},empname{empname},gross{gross}";
        }
    }
}
