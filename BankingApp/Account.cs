using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        public string AccountNumber { get; private set; }
        public string Name { get; private set; }

        private double balance;
        
        public double Balance
        {
            get { return balance; }
        }

        public Account(string accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;

        }



        public void Deposite(double amount)
        {
            balance = Balance + amount;
        }

        public void Withdraw (double amount)
        {
            balance = Balance - amount;
        }
    }
}
