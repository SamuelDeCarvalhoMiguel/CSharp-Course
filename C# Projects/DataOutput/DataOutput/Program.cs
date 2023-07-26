using System;
using System.Globalization;

namespace DataOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //example1();
            //example2();
            //example3();
            //Exercise.Exercise1();

        }

        static void Example1()
        {

            Console.WriteLine("Good morning!");
            Console.Write("Good afternoon! ");
            Console.WriteLine("Good evening!");

        }

        static void Example2()
        {

            char gender = 'F';
            int age = 32;
            double balance = 10.35784;
            string name = "Maria";

            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(balance);
            Console.WriteLine(name);
            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F4"));
            Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));


        }

        static void Example3()
        {

            char gender = 'F';
            int age = 32;
            double balance = 10.35784;
            string name = "Maria";

            Console.WriteLine("{0} is {1} years old and have R${2:f2} in her bank account.", name, age, balance);
            Console.WriteLine($"{name} is {age} years old and have R${balance:f2} in her bank account.");
            Console.WriteLine(name + "is " + age + " years old and have R$" + balance.ToString("F2") + " in her bank account.");



        }
    }
}
