using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] vector = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int roomAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < roomAmount; i++)
            {

                Console.WriteLine($"{i + 1}º Rent: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vector[room] = new Student(name, email);

            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++)
            {

                if (vector[i] != null)
                    Console.WriteLine($"{i}: {vector[i].Name}, {vector[i].Email}");

            }
        }
    }
}