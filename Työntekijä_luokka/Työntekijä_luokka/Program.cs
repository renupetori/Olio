using System;

namespace Työntekijä_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Rudi Rautiainen", 1, "Toimitusjohtaja", 8000.00);
            employees[1] = new Employee("Teemu Menttä", 2, "Myyjä", 2500.00);
            employees[2] = new Employee("Nils Hansson", 3, "Siistijä", 2500.00);
            employees[3] = new Employee("Johan Mattsson", 4, "Maskotti", 2000.00);

            Console.WriteLine(employees[1].CompareSalary(employees[0]));
            Console.WriteLine(employees[1].CompareSalary(employees[2]));
            Console.WriteLine(employees[1].CompareSalary(employees[3]));

            Console.ReadKey();
        }
    }
}
