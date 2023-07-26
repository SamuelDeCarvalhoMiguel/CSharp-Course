using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            //example1();
            //example2();

        }

        static void example1()
        {

            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;
            c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }

        static void example2()
        {

            int a = 5;
            int b = 2;

            double resultado = (double)a / b;

            Console.WriteLine(resultado);

        }
    }
}