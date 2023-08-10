using System;
using Enumeration.Entities;
using Enumeration.Entities.Enums;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {

            //example1();
            exercise1();

        }

        static void example1()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);
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
    }
}