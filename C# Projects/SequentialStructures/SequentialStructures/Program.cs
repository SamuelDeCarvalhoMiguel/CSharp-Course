using System;

namespace SequentialStructures
{
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

            int firstValue, secondValue, result;

            Console.Write("Type your first value: ");
            firstValue = int.Parse(Console.ReadLine());
            Console.Write("Type your first value: ");
            secondValue = int.Parse(Console.ReadLine());

            result = firstValue + secondValue;

            Console.WriteLine($"{firstValue} + {secondValue} = {result}");

        }

        static void exercise2()
        {
            double area, radius, pi;

            pi = 3.14159;

            Console.Write("Insert the circle radius: ");
            radius = double.Parse(Console.ReadLine());

            area = Math.Pow(radius, 2) * pi;

            Console.WriteLine($"Area = {area:f4}");

        }

        static void exercise3()
        {
            int a, b, c, d, difference;

            Console.Write("Insert the value of A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Insert the value of B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Insert the value of C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Insert the value of D: ");
            d = int.Parse(Console.ReadLine());

            difference = a * b - c * d;

            Console.WriteLine($"Diferrence: {difference}");

        }

        static void exercise4()
        {
            int code, workedHours;
            double salaryPerHour, salary;

            Console.Write("Insert the user code: ");
            code = int.Parse(Console.ReadLine());
            Console.Write("Insert the amount of worked hours: ");
            workedHours = int.Parse(Console.ReadLine());
            Console.Write("Insert the user salary: ");
            salaryPerHour = double.Parse(Console.ReadLine());

            salary = salaryPerHour * workedHours;

            Console.WriteLine($"User Code: {code}");
            Console.WriteLine($"Salary: U${salary}");

        }

        static void exercise5()
        {

            double price;

            Console.Write("Insert the product code, amount and price: ");
            string[] product1 = Console.ReadLine().Split(' ');
            Console.Write("Insert the product code, amount and price: ");
            string[] product2 = Console.ReadLine().Split(' ');

            double fisrtProdAmount = double.Parse(product1[1]);
            double fisrtProdPrice = double.Parse(product1[2]);
            double secondProdAmount = double.Parse(product2[1]);
            double secondProdPrice = double.Parse(product2[2]);

            price = fisrtProdAmount * fisrtProdPrice + secondProdAmount * secondProdPrice;

            Console.WriteLine($"Total Price: U${price}");

        }

        static void exercise6()
        {

            double a, b, c;

            Console.Write("Insert the value of A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Insert the value of B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Insert the value of C: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle: {0:f3}", (a * c) / 2);
            Console.WriteLine("Circle: {0:f3}", 3.14159 * Math.Pow(c, 2));
            Console.WriteLine("Trabezoid: {0:f3}", ((a + b) * c) / 2);
            Console.WriteLine("Square: {0:f3}", Math.Pow(b, 2));
            Console.WriteLine("Rectangle: {0:f3}", a * b);


        }

    }
}