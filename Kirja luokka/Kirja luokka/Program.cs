using System;

namespace Kirja_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Pahan polku", "Robert Galbraith", 00254, 8.50);

            book1.PrintBook();
            book2.PrintBook();

            Console.WriteLine(book1.Compare(book2));
            Console.ReadKey();
        }
    }
}
