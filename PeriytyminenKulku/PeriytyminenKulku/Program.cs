using System;

namespace PeriytyminenKulku
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Auto("Henkilöauto", "BMW", 2012, 5900.00, "1598 cm3", "F21 1 Series", 4);
            vehicle1.PrintInfo();
            Console.WriteLine();

            Vehicle vehicle2 = new Truck("Kuorma-auto", "Ford", 2016, 40940.00, "No info", "Cargo 3542 D", 2, 7500, 0.2);
            vehicle2.PrintInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
