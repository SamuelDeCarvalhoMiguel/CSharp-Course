using System;
using System.Globalization;
using Enumeration.Entities;
using Enumeration.Entities.Enums;
using Enumeration.Entities.Ex1;
using Enumeration.Entities.Ex2;

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

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(DateTime.Parse("21 / 06 / 2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            post1.AddComment(c1);
            post1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post post2 = new Post(DateTime.Parse("21 / 06 / 2018 13:05:44"), "Good night guys", "See you tomorrow", 5);

            post2.AddComment(c3);
            post2.AddComment(c4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);

        }

        static void exercise3()
        {

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}