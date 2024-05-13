using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public delegate void MyBankDelete();
   public  class Bank
    {
        public event MyBankDelete LowBalance;
        private double balance;

        public Bank() {
            balance = 5000;
        }

        public void Withdraw(double amount) {

            if (amount > balance) { 
               
            
            }
        }
    }

}
