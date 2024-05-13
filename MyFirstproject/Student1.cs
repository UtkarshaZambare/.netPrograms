using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class Student1
    {
        private int id;
        private string name;
        private int m1, m2, m3;

        public void AcceptDetails( int id, string name, int m1, int m2, int m3) {

            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public double CalculatePercentage() {

            int totalmarks = m1 + m2 + m3;
            return (double)totalmarks / 3;

        }

        public string DisplayDetails() {

            double Percentage = CalculatePercentage();

            return $"id {id} , name {name} , m1 {m1}, m2 {m2} , m3{m3}, percentage {Percentage}";
        }
    }
}
