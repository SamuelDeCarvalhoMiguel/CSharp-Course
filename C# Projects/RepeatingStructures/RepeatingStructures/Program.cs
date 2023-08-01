using System;
using System.Globalization;

namespace RepeatingStructures{
    class Program
    {
        static void Main(string[] args)
        {

            //exercise1();
            //exercise2();
            //exercise3();
            //exercise4();
            //exercise5();
            //exercise6();

        }

        static void exercise1()
        {

            string password = "";

            Console.Write("password: ");
            password = Console.ReadLine();

            while (password != "2002")
            {
                Console.WriteLine("Invalid password. Please Try again!");
                Console.Write("password: ");

                password = Console.ReadLine();
            }

            Console.WriteLine("Permitted Access");

        }

        static void exercise2()
        {
            string[] positions;

            Console.Write("Insert the positions: ");
            positions = Console.ReadLine().Split();

            double x = double.Parse(positions[0]);
            double y = double.Parse(positions[1]);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                    Console.WriteLine("First.");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Second.");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Third.");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Fourth.");

                Console.Write("Insert the positions: ");
                positions = Console.ReadLine().Split();

                x = double.Parse(positions[0]);
                y = double.Parse(positions[1]);

            }
        }

        static void exercise3()
        {

            int alcohol = 0, gasoline = 0, diesel = 0;

            Console.WriteLine("Select your option: ");
            Console.WriteLine("[1]Alcohol [2]Gasoline [3]Diesel [4]Close");

            int choice = int.Parse(Console.ReadLine());

            while (choice != 4)
            {

                switch (choice)
                {
                    case 1:
                        alcohol += 1;
                        break;

                    case 2:
                        gasoline += 1;
                        break;

                    case 3:
                        diesel += 1;
                        break;

                    default:
                        Console.WriteLine("Incorrect option. Please try again!\n");
                        break;
                }

                Console.WriteLine("Select your option: ");
                Console.WriteLine("[1]Alcohol [2]Gasoline [3]Diesel [4]Close");

                choice = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Thank you!");
            Console.WriteLine($"Alcohol: {alcohol}");
            Console.WriteLine($"Gasoline: {gasoline}");
            Console.WriteLine($"Diesel: {diesel}");

        }

        static void exercise4()
        {

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
        }

        static void exercise5()
        {
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

        }

        static void exercise6()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}