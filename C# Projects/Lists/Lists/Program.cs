using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int amount = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < amount; i++) 
            {

                Console.WriteLine($"{i + 1}º Employee: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine(); 
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary)); 

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == employeeId);

            if (emp != null)
            {
                Console.Write("Enter the percentage:");
                decimal percentage = decimal.Parse(Console.ReadLine());
                emp.SalaryIncrease(percentage);
            }

            else
                Console.WriteLine("This ID doesn't exist!");

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach(Employee i in employees){

                Console.WriteLine($"{i.Id}, {i.Name}, {i.Salary}");

            }
        }
    }
}