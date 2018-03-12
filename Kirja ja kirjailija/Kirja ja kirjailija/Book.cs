using System;
using System.Collections.Generic;
using System.Text;

namespace Kirja_ja_kirjailija
{
    class Book
    {
        public string Title;
        public readonly string Author;
        public string Publisher;
        public double Price;
        static string Theme;
        
        public Book()
        {

        }

        public Book(string title, string author, string publisher, double price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = price;
        }

        public void GetBook(string title)
        {
            if (Title == title)
            {
                Console.WriteLine($"Kirja: {Title}\nKirjailija: {Author}\nJulkaisija: {Publisher}\nHinta: {Price}\nTeema: {Theme}");
            }
            else
            {
                Console.WriteLine($"Kirjaa nimeltä: {title} ei löytynyt!");
            }
        }

        public static void ChangeTheme(string theme)
        {
            Theme = theme;
        }

        public double PriceP
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 30)
                {
                    Price = value * 0.9;
                }
                else
                {
                    Price = value;
                }
            }
        }

    }
}
