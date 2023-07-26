using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            //example1();
            //example2();
            example3();

        }

        static void example1()
        {

            sbyte a = -128;
            SByte b = -127;
            byte c = 255;
            int d = 2147483647;
            long e = 2147483648L; //Ao utilizar long é recomendado colocar o sufíxo "L" no final.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

        }

        static void example2()
        {

            bool complete = false;
            char gender = 'F';
            char letter = '\u0041';
            float n1 = 4.5f;
            double n2 = 4.5;
            string name = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5;

            Console.WriteLine(complete);
            Console.WriteLine(gender);
            Console.WriteLine(letter);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(name);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


        }

        static void example3()
        {
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}