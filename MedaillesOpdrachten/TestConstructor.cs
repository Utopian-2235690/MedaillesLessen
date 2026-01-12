using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Car
    {

        private string _name;
        private string _brand;
        private int _amountOfDoors;

        public Car(string Name, string Brand, int AmountOfDoors)
        {
            _name = Name;
            _brand = Brand;
            _amountOfDoors = AmountOfDoors;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Auto naam is {_name}, het merk is {_brand}.");
            Console.WriteLine("");
        }

    }
}
