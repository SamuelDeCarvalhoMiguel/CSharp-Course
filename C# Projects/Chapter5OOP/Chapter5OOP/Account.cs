using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5OOP
{
    internal class Account
    {

        public int AccountNumber { get; private set; }
        public string Name { get; set; }
        public decimal Balance { get; private set; }

        public Account(int AccountNumber, string name, decimal deposit)
        {

            this.AccountNumber = AccountNumber;
            Name = name;
            Balance = deposit;

        }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(decimal withdraw)
        {
            Balance -= withdraw + 5;
        }

    }
}
