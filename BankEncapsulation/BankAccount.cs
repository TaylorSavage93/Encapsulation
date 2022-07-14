using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        
        public void Deposit(double amount)
        {
            balance = amount;   
        }
        public double GetBalance()
        {
            return balance;

        }
        public void Withdraw(double money)
        {
            balance = balance - money;
        }

    }
}
