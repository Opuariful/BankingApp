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
        private string number;
        private string name;
        private double balance;


        public string Number
        {
            set
            {number = value;}

            get
            {return number;}
        }

        public string Name
        {
            set
            {name = value;}

            get
            {return name;}
        }

        public double Balance
        {
            

            get
            {
                return balance;
            }
        }
        public void Deposite(double amount)
        {
            balance += amount;
        }

        public void Withdraw (double amount)
        {
            balance -= amount;
        }
    }
}
