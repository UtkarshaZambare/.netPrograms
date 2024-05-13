using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    abstract class Sum1
    {
       protected  int num1;

        public Sum1(int num1) {

            this.num1 = num1;
        }

    }

    interface MyInterface {

        int num2 { get; set; }
    }

     class ChildClass  : Sum1, MyInterface
    {
        public int num2{ get; set; }

        public ChildClass( int num2,int num1) : base(num1)
        {
           num2 = num2;
        }

        public int AddNumbers()
        {
            return num1 + num2;
        }

        /*public class Main {

            static void main(String[] args) {

                ChildClass obj = new ChildClass(10, 20);
                int sum = obj.AddNumbers();
                Console.WriteLine($"Sum of numbers: {sum}");
            
            }
        }*/
    }

}
