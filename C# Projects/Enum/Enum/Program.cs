using System;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            example1();

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


        }
    }
}