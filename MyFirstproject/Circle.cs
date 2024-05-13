using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class Circle :Shape
    {
        private int radius;
        private double area;

        public Circle(int radius) {

            this.radius = radius;
        }

        public override void CalculateArea()
        {
            area = 3.14 * radius * radius;
        }

        public string Print ()
        {
            return $"Area of Circle {area}";
        }
    }
}
