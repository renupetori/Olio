using System;
using System.Collections.Generic;
using System.Text;

namespace PeriytyminenKulku
{
    abstract class Vehicle
    {
        protected string Classification;
        protected string Brand;
        protected int Year;
        protected double Price;

        public Vehicle()
        {
        }

        public Vehicle(string _classification, string _brand, int _year, double _price)
        {
            Classification = _classification;
            Brand = _brand;
            Year = _year;
            Price = _price;
        }

        abstract public void PrintInfo();
    }
}
