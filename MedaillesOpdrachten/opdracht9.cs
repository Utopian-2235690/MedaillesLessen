using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Weapon
    {

        private string _Name;
        private int _Damage;

        public Weapon(string Name, int Damage)
        {
            _Name = Name;
            _Damage = Damage;
        }

        public void ShowStats()
        {
            Console.WriteLine($"{_Name} doet {_Damage} damage.");
        }

        public void UpgradeWeapon(int DamageToAdd)
        {
            _Damage += DamageToAdd;
        }

    }
}
