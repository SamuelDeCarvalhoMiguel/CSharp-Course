using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            //example1();
            //example2();
            Exercise.exercise1();

        }

        static void example1() 
        {
            string frase, x, y, z;

            Console.WriteLine("Write a text:");

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            string[] array = Console.ReadLine().Split(' ');

            Console.WriteLine("You wrote: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }

        static void example2()
        {

            Console.WriteLine("Write a text: ");

            int firstNumber = int.Parse(Console.ReadLine());
            char word = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string[] personData = Console.ReadLine().Split(' ');

            Console.WriteLine("You Wrote: ");
            Console.WriteLine(firstNumber);
            Console.WriteLine(word);
            Console.WriteLine(secondNumber);
            Console.WriteLine("Your data: ");
            Console.WriteLine(personData[0]);
            Console.WriteLine(personData[1]);
            Console.WriteLine(personData[2]);
            Console.WriteLine(personData[3]);




        }
    }
}