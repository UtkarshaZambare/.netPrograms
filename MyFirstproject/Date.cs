using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public  class Date
    {
        private int dd;
        private int mm;
        private int yy;

        public Date()
        {
            dd = 23;
            mm = 07;
            yy = 2024;
        }

        public Date(int dd, int mm, int yy) {

            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }

        public string Display() {

            return $" {dd} :  {mm} : {yy}";
        }

        
    }
}
