using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_luokka
{
    class Car
    {
        public string Brand;
        public int Speed;

        public Car(int AccelerateVal)
        {
            AskData();
            ShowCarInfo();
            Accelerate(AccelerateVal);
            Brake();
        }

        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki: ");
            Brand = Console.ReadLine();
            Console.WriteLine("Syötä sen nopeus: ");
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki: {Brand}\nAuton nopeus: {Speed}km/h");
        }

        public void Accelerate()
        {
            
        }

        public void Accelerate(int addedSpeed)
        {
            if (addedSpeed > 0)
            {
                Speed = Speed + addedSpeed;
                Console.WriteLine($"Auton nopeus kiihdytyksen jälkeen on: {Speed}km/h");
            }
            else
            {
                Console.WriteLine($"Negatiivinen muutos ei ole sallittu kiihdytyksessä.");
            }
        }

        public void Brake()
        {
            Console.WriteLine($"Auton nopeus jarrutuksen jälkeen on: {Speed * 0.9}km/h\n");
        }
    }
}
