using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mini Dungeon!");
            new Character.CharacterCreation();

            Console.WriteLine($"Your name is {Character.CharacterCreation._name}.");
            Console.ReadKey();

            new Character.Character();

            new Level.Level1();

            Console.WriteLine($"STR is: {Character.Character._stats["STR"]}");
            Console.ReadKey();


        }
    }
}
