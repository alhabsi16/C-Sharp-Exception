using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_ApplicationException
{
    internal class BankAccount
    {
        private int balance;

        public BankAccount(int balance)
        {
            this.balance = balance;
        }


        public double Withdraw(int amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException();
            }

            return balance -= amount;
        }
        
    }
}
