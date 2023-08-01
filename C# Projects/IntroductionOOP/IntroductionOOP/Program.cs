using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace IntroductionOOP
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
            exercise6();

        }

        static void exercise1()
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person();

            Console.WriteLine($"1º Person data:");
            Console.Write("Name: ");
            firstPerson.Name = Console.ReadLine();
            Console.Write("Age: ");
            firstPerson.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"2º Person data:");
            Console.Write("Name: ");
            secondPerson.Name = Console.ReadLine();
            Console.Write("Age: ");
            secondPerson.Age = int.Parse(Console.ReadLine());

            if (firstPerson.Age > secondPerson.Age)
                Console.WriteLine($"Oldest person: {firstPerson.Name}");

            else
                Console.WriteLine($"Oldest person: {secondPerson.Name}");
        }

        static void exercise2()
        {

            Person firstUser = new Person();
            Person secondUser = new Person();

            Console.WriteLine("1º user data:");
            Console.Write("Name: ");
            firstUser.Name = Console.ReadLine();
            Console.Write("Salary: R$");
            firstUser.Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("2º user data:");
            Console.Write("Name: ");
            secondUser.Name = Console.ReadLine();
            Console.Write("Salary: R$");
            secondUser.Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Avarage salary: {(firstUser.Salary + secondUser.Salary) / 2}");

        }

        static void exercise3()
        {

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Insert the height and width of the rectangle: ");
            Console.Write("Height: ");
            rectangle.Height = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            rectangle.Width = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {rectangle.Area():f2}");
            Console.WriteLine($"Perimeter = {rectangle.Perimeter(rectangle.Height, rectangle.Width):f2}");
            Console.WriteLine($"Diagonal = {rectangle.Diagonal(rectangle.Height, rectangle.Width):f2}");

        }

        static void exercise4()
        {

            Employee employee = new Employee();

            Console.WriteLine("Employee's data: ");
            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Full Salary: ");
            employee.FullSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Tax: ");
            employee.Tax = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Employee: {employee.Name}, U$ {employee.ActualSalary():f2}");

            Console.Write("Insert the raise porcentage: ");
            decimal raise = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Updated data: {employee.Name}, U$ {employee.Raise(raise):f2}");

        }

        static void exercise5()
        {

            Student student = new Student();

            Console.Write("Student name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Insert the student notes: ");
            student.FirstNote = double.Parse(Console.ReadLine());
            student.secondNote = double.Parse(Console.ReadLine());
            student.ThirdNote = double.Parse(Console.ReadLine());

            Console.WriteLine($"Final note: {student.FinalNote()}");
            Console.WriteLine(student.Approved());

            if (student.FinalNote() < 60)
                Console.WriteLine($"The student need {student.neededNote()} points.");

        }

        static void exercise6() 
        {

            Console.Write("Insert the dollar price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Insert the amount that you want to buy: ");
            double amountBought = double.Parse(Console.ReadLine());

            Console.WriteLine($"{CurrencyConverter.DollarToReal(price, amountBought):f2}");

        }

    }
}