using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStructure
{
    internal class Exercise
    {

        public static void exercise1()
        {

            int number;

            Console.Write("Type a number: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.Write("This number is negative.");
            }

            else if (number > 0)
            {
                Console.WriteLine("This number is positive.");
            }

            else
            {
                Console.WriteLine("This number is neutral.");
            }

        }

        public static void exercise2()
        {
            double firstNumber;

            Console.WriteLine("Insert the first value: ");
            firstNumber = double.Parse(Console.ReadLine());

            if (firstNumber % 2 == 0)
            {
                Console.WriteLine("This value is even.");
            }

            else
            {
                Console.WriteLine("This value is odd.");

            }

        }

        public static void exercise3()
        {
            double firstNumber, secondNumber;

            Console.Write("Type the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0)
                Console.WriteLine("These values are mutiples.");

            else
                Console.WriteLine("These values are not mutiples.");

        }

        public static void exercise4()
        {

            int startTime, endTime, duration;

            Console.Write("Type the time that the game started: ");
            startTime = int.Parse(Console.ReadLine());

            Console.Write("Type the time that the game ended: ");
            endTime = int.Parse(Console.ReadLine());

            if (endTime <= startTime)
                endTime += 24;

            duration = endTime - startTime;

            Console.WriteLine($"The game duration was {duration}");
        }

        public static void exercise5()
        {

            int code, amount;
            double price = 0;

            Console.Write("Product code: ");
            code = int.Parse(Console.ReadLine());
            Console.Write("Amount: ");
            amount = int.Parse(Console.ReadLine());

            switch (code)
            {

                case 1:
                    price = 4.00;

                    Console.WriteLine($"Total value: R${price * amount:f2}");

                    break;

                case 2:
                    price = 4.50;

                    Console.WriteLine($"Total value: R${price * amount:f2}");

                    break;

                case 3:
                    price = 5.00;

                    Console.WriteLine($"Total value: R${price * amount:f2}");

                    break;

                case 4:
                    price = 2.00;

                    Console.WriteLine($"Total value: R${price * amount:f2}");

                    break;

                case 5:
                    price = 1.50;

                    Console.WriteLine($"Total value: R${price * amount:f2}");

                    break;

                default:
                    Console.WriteLine("Product not found");

                    break;

            }

        }

        public static void exercise6() 
        {

            double value;

            Console.Write("Type a value: ");
            value = double.Parse(Console.ReadLine());

            if (value >= 0 && value <= 25)
                Console.WriteLine("Interval: [0, 25]");

            else if (value > 25 && value <= 50)
                Console.WriteLine("Interval: [25, 50]");


            else if (value > 50 && value <= 75)
                Console.WriteLine("Interval: [50, 75]");

            else if (value > 75 && value <= 100)
                Console.WriteLine("Interval: [75, 100]");

            else
                Console.WriteLine("Out of range.");

        }

        public static void exercise7()
        {

            double xLocation, yLocation;

            Console.Write("Type X value: ");
            xLocation = double.Parse(Console.ReadLine());
            Console.Write("Type Y value: ");
            yLocation = double.Parse(Console.ReadLine());

            if (xLocation == 0 && yLocation == 0)
                Console.WriteLine("Origin");
            else if (xLocation > 0 && yLocation > 0)
                Console.WriteLine("Q1");
            else if (xLocation < 0 && yLocation > 0)
                Console.WriteLine("Q2");
            else if (xLocation < 0 && yLocation < 0)
                Console.WriteLine("Q3");
            else if (xLocation > 0 && yLocation < 0)
                Console.WriteLine("Q4");

        }

        public static void exercise8()
        {

            double salary, taxes = 0;

            Console.Write("Insert the user salary: ");
            salary = double.Parse(Console.ReadLine());

            if (salary > 4500)
            {
                taxes += (salary - 4500) * 0.28;
                salary -= salary - 4500;
            }

            if (salary > 3000 && salary <= 4500)
            {
                taxes += (salary - 3000) * 0.18;
                salary -= salary - 3000;
            }

            if (salary > 2000 && salary <= 3000)
            {
                taxes += (salary - 2000) * 0.08;
                salary -= salary - 2000;
            }

            if (taxes == 0)
                Console.WriteLine("Free of taxes.");

            else
                Console.WriteLine($"R$ {taxes:f2}");



        }

    }
}
