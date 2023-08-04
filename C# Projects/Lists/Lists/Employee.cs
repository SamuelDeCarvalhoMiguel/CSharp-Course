using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Employee
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Salary { get; private set; }

        public Employee(int id, string name, decimal salary)
        {

            Id = id;
            Name = name;
            Salary = salary;

        }

        public decimal SalaryIncrease( decimal percentage)
        {

            Salary += Salary * (percentage / 100);
            return Salary;

        }

    }
}
