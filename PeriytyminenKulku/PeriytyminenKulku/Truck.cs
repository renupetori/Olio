using System;
using System.Collections.Generic;
using System.Text;

namespace PeriytyminenKulku
{
    class Truck : Auto
    {
        protected double CargoWeight;
        protected double ConsumptionPerKg;
        
        public Truck(string _type, string _brand, int _year, double _price, string _machineSize, string _model, int _doors, double _cargoWeight, double _consumptionPerKg) : base(_type, _brand, _year, _price, _machineSize, _model, _doors)
        {
            CargoWeight = _cargoWeight;
            ConsumptionPerKg = _consumptionPerKg;
        }

        protected double CalculateConsumption()
        {
            double _consumption = CargoWeight * ConsumptionPerKg / 10000;
            return _consumption;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\nKuorman paino on {CargoWeight} kg\nKulutus kilometriä kohden on {CalculateConsumption()}l");
        }
        
    }
}
