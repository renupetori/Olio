using System;

namespace Firma_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company("Kaluste Oy","Suokatu 3","045 1234 567",12000.00,9500.00);
            Console.ReadKey();

            Company company2 = new Company(company1.Title,company1.Address,company1.Phone,20000.00,3000.00);
            Console.ReadKey();

            Company company3 = new Company(company1);
            Console.ReadKey();
        }
    }
}
