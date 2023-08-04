using System;
using System.Globalization;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //example1();
            //example2();
            example3();

        }

        static void example1()
        {

            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

        }

        static void example2()
        {

            DateTime d1 = new DateTime(2023, 08, 04);
            DateTime d2 = new DateTime(2023, 08, 04, 16, 07, 30);
            DateTime d3 = new DateTime(2023, 08, 04, 16, 07, 30, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

        }

        static void example3()
        {

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:08");
            DateTime d3 = DateTime.Parse("15-08-2000");
            DateTime d4 = DateTime.Parse("15-08-2000 13:05:08");

            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

        }
    }
}