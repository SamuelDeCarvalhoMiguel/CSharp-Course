using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOOP
{
    internal class Employee
    {

        public string Name;
        public decimal FullSalary;
        public decimal Tax;

        public decimal ActualSalary()
        {
            return FullSalary - Tax;
        }

        public decimal Raise(decimal raise)
        {
            return (FullSalary * (raise / 100)) + ActualSalary();
        }

    }
}
