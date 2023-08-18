using System;
using Inheritance.Entities;
using Inheritance.Entities.Examples;
using Inheritance.Entities.Ex1;
using Inheritance.Entities.Ex2;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Example1();
            //Example2();
            //Example3();
            //exercise1();
            exercise2();

        }

        static void Example1()
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0; // error
        }

        static void Example2()
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1003, "Bob", 0.0, 200.0);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

           //BusinessAccount acc5 = (BusinessAccount)acc3; /error

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }

        static void Example3()
        {

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }

        static void exercise1()
        {

            Console.Write("Enter the number of employees: ");
            int amount = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < amount; i++)
            {

                Console.WriteLine($"Employee {i + 1}º data:");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if  (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment():f2}");
            }

        }

        static void exercise2()
        {

            Console.Write("Enter the number of products: ");
            int amount = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= amount; i++)
            {

                Console.WriteLine($"Product {i}º data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (productType == 'i')
                {
                    Console.Write("Custmos Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(productName, price, customsFee));
                }

                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(productName, price, manufactureDate));
                }
                
                else
                    products.Add(new Product(productName, price));

            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}