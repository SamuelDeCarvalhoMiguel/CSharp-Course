using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOutput
{
    internal class Exercise
    {
        public static void Exercise1()
        {

            string product1 = "Computer";
            string product2 = "Office desk";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine($"{product1} price is $ {price1}");
            Console.WriteLine($"{product2} price is $ {price1}\n");
            Console.WriteLine($"Register: {age} years old, code {code} and gender {gender}");
            Console.WriteLine($"measure to 8 decimal places: {measure}");
            Console.WriteLine($"measure to 3 decimal places: {measure}");
            Console.WriteLine("measure to 3 decimal places: " + measure.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
