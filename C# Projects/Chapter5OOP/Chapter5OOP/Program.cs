using System;
using System.Security.Principal;

namespace Chapter5OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal deposit = 0;

            Console.Write("Insert account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Insert account's owner name: ");
            string name = Console.ReadLine();

            Console.Write("Initial deposit (s/n)? ");
            char depositChoice = char.Parse(Console.ReadLine());

            if (depositChoice == 's' || depositChoice == 'S')
            {

                Console.Write("Insert the initial deposit: $");
                deposit = decimal.Parse(Console.ReadLine());

            }

            Account account = new Account(accountNumber, name, deposit);

            Console.WriteLine("Account data: ");
            Console.WriteLine($"Account {account.AccountNumber}, Owner: {account.Name}, Balance: ${account.Balance:f2}\n");

            Console.Write("Insert a value to deposit: $");
            account.Deposit(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Account data: ");
            Console.WriteLine($"Account {account.AccountNumber}, Owner: {account.Name}, Balance: ${account.Balance:f2}\n");

            Console.Write("Insert a value to withdraw: $");
            account.Withdraw(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Account data: ");
            Console.WriteLine($"Account {account.AccountNumber}, Owner: {account.Name}, Balance: ${account.Balance:f2}\n");

        }
    }
}