using System;
using System.Collections.Generic;
using System.Text;

namespace PeriytyminenKulku
{
    class Auto : Vehicle
    {
        protected string MachineSize;
        protected string Model;
        protected int Doors;

        public Auto()
        {
        }

        public Auto(string _classification, string _brand, int _year, double _price, string _machineSize, string _model, int _doors) : base(_classification, _brand, _year, _price)
        {
            MachineSize = _machineSize;
            Model = _model;
            Doors = _doors;
        }

        public override string ToString()
        {
            return ($"Autotyyppi: {Classification}\nMerkki: {Brand}\nVuosimalli: {Year}\nHinta: {Price}\nMoottori: {MachineSize}\nMalli: {Model}\nOvien määrä: {Doors}");
        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }


}
