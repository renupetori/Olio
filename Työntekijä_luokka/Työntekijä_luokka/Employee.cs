using System;
using System.Collections.Generic;
using System.Text;

namespace Työntekijä_luokka
{
    class Employee
    {
        string Name;
        int Id;
        string Position;
        double Salary;

        public Employee()
        {

        }

        public Employee(string name, int id, string position, double salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
            PrintEmployeeInfo();
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijä: {Name}\nId: {Id}\nTyötehtävä: {Position}\nPalkka: {Salary} euroa\n");
        }

        public string CompareSalary(Employee employee)
        {
            if (Salary > employee.Salary)
            {
                return ($"Työntekijän {Name} palkka on suurempi kuin työntekijän {employee.Name} palkka.\n");
            }
            else if (Salary < employee.Salary)
            {
                return ($"Työntekijän {Name} palkka on pienempi kuin työntekijän {employee.Name} palkka.\n");
            }
            else
            {
                return ($"Työntekijän {Name} palkka on yhtäsuuri kuin työntekijän {employee.Name} palkka.\n");
            }
        }
    }
}
