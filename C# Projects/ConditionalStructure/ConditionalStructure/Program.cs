using System;

namespace ConditionalStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //example1();
            //example2();
            //Exercise.exercise1();
            //Exercise.exercise2();
            //Exercise.exercise3();
            //Exercise.exercise4();
            //Exercise.exercise5();
            //Exercise.exercise6();
            //Exercise.exercise7();
            Exercise.exercise8();

        }

        static void example1()
        {

            Console.WriteLine("What time is it? ");
            int hour = int.Parse(Console.ReadLine());

            if (hour <= 12)
            {
                Console.WriteLine("Good morning");
            }

            else if (hour > 12 && hour <= 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            else if (hour > 17 && hour <= 24)
            {
                Console.WriteLine("Good evening");
            }

            else
            {
                Console.WriteLine("You wrote a invalid time.");
            }

        }

        static void example2()
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
    }
}