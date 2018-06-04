using System;
using System.Collections.Generic;
using System.Text;

namespace Kirja_ja_kirjailija
{
    class Author
    {

        public string Name;
        public string DateOfBirth;
        Book Book;

        public Author()
        {
        }

        public Author(string name, string iDateOfBirth, Book book)
        {
            Name = name;
            DateOfBirth = iDateOfBirth;
            Book = book;
        }


        public void PrintAuthor()
        {
            Console.WriteLine($"----\nKirjailija: {Name}\nSyntymäaika: {DateOfBirth}\n\nKirja:\n");

            if (Name == Book.Author)
            {
                Book.PrintBook();
            }
            else
            {
                Console.WriteLine("\n----Kirjailija ei ole kirjoittanut etsimääsi kirjaa.");
            }
        }

    }
}
