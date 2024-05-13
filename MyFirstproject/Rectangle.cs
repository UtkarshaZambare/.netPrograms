using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public class Rectangle : Shape 
    {
     private  int length;
        private int breadth;
        double area;

        public Rectangle(int length, int breadth) {

            this.length = length;
            this.breadth = breadth;
        
        }
        public override void CalculateArea()
        {
             area = length * breadth;
        }

        public string Print (){
            return $"Area of rectangle {area}";
        }
    }
    
    
}
