using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class NameException: Exception
    {
        public NameException(string error): base(error) { 
        }
    }

    public class Person {


        private string name;

        public void AcceptName(string name) {

            if (!string.IsNullOrEmpty(name)) {
                this.name = name;
            }
            else {
                throw new NameException("Name is requried");
            }
        
        }
    }
}
