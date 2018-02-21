using System;
using System.Collections.Generic;
using System.Text;

namespace Kirja_luokka
{
    class Book
    {
        public string Title;
        public string Author;
        public int Id;
        public double Price;
        
        public Book()
        {
            Title = "Ohrana";
            Author = "Jari Tervo";
            Id = 01234;
            Price = 8.90;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }
        
        public void PrintBook()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\nKirjailija: {Author}\nID: {Id}\nHinta: {Price} euroa\n");
            Console.ReadKey();
        }

        public string Compare(Book book)
        {
            if (this.Price > book.Price)
            {
                return ($"{this.Title} on kalliimpi kuin {book.Title}.");
            }
            else
            {
                return ($"{book.Title} on kalliimpi kuin {this.Title}.");
            }
        }
    }
}
