using System;
using System.Globalization;
using Enumeration.Entities;
using Enumeration.Entities.Enums;
using Enumeration.Entities.Ex1;
using Enumeration.Entities.Ex2;
using Enumeration.Entities.Ex3;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {

            //exercise1();
            //exercise2();
            exercise3();

        }

        static void exercise1()
        {

            Department department = new Department();
            Worker worker = new Worker();

            Console.Write("Enter department's name: ");
            department.Name = Console.ReadLine();

            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: ");
            worker.Name = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker? ");
            int contractAmount = int.Parse(Console.ReadLine());

            HourContract hourContract = new HourContract();

            for (int i = 0; i < contractAmount; i++)
            {

                Console.WriteLine($"Enter {i + 1}º contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                hourContract.Date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                hourContract.ValuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (Hours): ");
                hourContract.Hours = int.Parse(Console.ReadLine());

                worker.AddContract(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] monthAndYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[0]);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Income for {monthAndYear[0]}/{monthAndYear[1]}: {worker.Income(year, month)}");

        }

        static void exercise2()
        {

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), 
                "Traveling to New Zealand", 
                "I'm going to visit this wonderful country!", 
                12);

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }

        static void exercise3()
        {

            Client client = new Client();

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();

            Console.Write("Email: ");
            client.Email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            OrderStatus status = new OrderStatus();

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int itemAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemAmount; i++)
            {

                Console.WriteLine($"Enter {i + 1}º item data: ");
                Console.Write("Product name: ");
                string name = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}