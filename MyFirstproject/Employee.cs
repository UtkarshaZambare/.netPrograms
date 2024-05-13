using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class Employee
     {
        protected int empid;
        protected string empname;
        protected double bs, hra, pf, gross;

        public void Assign() {
            empid = 1;
            empname = "Rima";
            bs = 40000;
            hra = 2000;
            pf = 3000;
        }

        public Employee() {
        }

        public Employee (int id , string name,double b,double h,double p) {

            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;

        }

        public virtual void    CalculateSalary() {

            gross = (bs + hra) - pf;
        }

        public virtual  string Display() {
            return $" Employee salary :empid {empid},empname{empname},gross{gross}";
        }
     }
}
