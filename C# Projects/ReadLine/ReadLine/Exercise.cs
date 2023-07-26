using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    internal class Exercise
    {

        public static void exercise1()
        {

            Console.Write("Type your name: ");
            string name = Console.ReadLine();

            Console.Write("How many rooms do you have in your house? ");
            int room = int.Parse(Console.ReadLine());

            Console.Write("Type a value price: R$");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Type your name, age and height (same line): ");
            string[] personData = Console.ReadLine().Split(' ');

            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.WriteLine(productPrice);
            Console.WriteLine(personData[0]);
            Console.WriteLine(personData[1]);
            Console.WriteLine(personData[2]);



        }

    }
}
