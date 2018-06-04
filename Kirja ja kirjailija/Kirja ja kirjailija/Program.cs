using System;

namespace Kirja_ja_kirjailija
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Book 1", "Meier", "DX Publishing", 29.95);
            book1.GetBook("Book 1");
            Book.ChangeTheme("Scifi");
            book1.PriceP = 39.95;
            Console.WriteLine($"----\nHinta ja teema muutettu.");
            book1.GetBook("Book 1");


            Book book2 = new Book("Book 2", "Sid", "OPX Publishing", 24.95);
            book2.GetBook("Book 2");
            Book.ChangeTheme("History");
            book2.PriceP = 29.95;
            Console.WriteLine($"----\nHinta ja teema muutettu.");
            book2.GetBook("Book 2");

            book1.GetBook("Book 3");

            Author author1 = new Author("Meier", "1984-03-23", book1);
            author1.PrintAuthor();

            Author author2 = new Author("Sid", "1990-12-01", book2);
            author2.PrintAuthor();

            Console.ReadKey();

        }
    }
}
