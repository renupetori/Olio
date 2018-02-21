using System;
using System.Collections.Generic;
using System.Text;

namespace Lippu
{
    class Ticket
    {
        public string Name;
        public int Age;
        public bool Conscript;
        public bool Student;
        public bool Mtk;

        public Ticket()
        {
            TicketData();
            PrintTicket();
            TicketPrice();
        }

        public void TicketData()
        {
            Console.WriteLine("Syötä nimesi: ");
            Name = Console.ReadLine();

            bool isNumber;
            do
            {
                Console.WriteLine("Syötä ikäsi: ");
                string age = Console.ReadLine();
                isNumber = int.TryParse(age, out Age);
                if (isNumber != true)
                {
                    Console.WriteLine("Syötä oikea luku!");
                }
            } while (isNumber != true);

            string student;
            do
            {
                Console.WriteLine("Oletko opiskelija? y/n");
                student = Console.ReadLine();
                if (student == "y")
                {
                    Student = true;
                }
            } while (student != "y" && student != "n");

            string conscript;
            if (Student == false)
                do
                {
                    Console.WriteLine("Oletko varusmies? y/n");
                    conscript = Console.ReadLine();
                    if (conscript == "y")
                    {
                        Conscript = true;
                    }
                } while (conscript != "y" && conscript != "n");

            string mtk;
            do
            {
                Console.WriteLine("Oletko MTK:n jäsen? y/n");
                mtk = Console.ReadLine();
                if (mtk == "y")
                {
                    Mtk = true;
                }
            } while (mtk != "y" && mtk != "n");
        }

        public void TicketPrice()
        {
            double price = 16.00;

            if (Age < 7)
            {
                price = price * 0;
            }

            else if (Mtk == true && Student == true)
            {
                price = price * 0.85 * 0.55;
            }
            else if (Age <= 15)
            {
                price = price * 0.50;
            }
            else if (Age >= 65)
            {
                price = price * 0.50;
            }
            else if (Conscript == true)
            {
                price = price * 0.50;
            }
            else
            {
                if (Student == true)
                {
                    price = price * 0.55;
                }
                if (Mtk == true)
                {
                    price = price * 0.85;
                }
            }
            Console.WriteLine($"Lipun hinta on: {price} euroa\n");
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Nimi: {Name}\nIkä: {Age}\nVarusmies: {Conscript}\nOpiskelija: {Student}\nMTK-jäsen: {Mtk}\n");
        }
    }
}