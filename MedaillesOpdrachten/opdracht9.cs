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
        private string _Type;

        public Weapon(string Name, int Damage, string Type)
        {
            _Name = Name;
            _Damage = Damage;
            _Type = Type;
        }

        public void ShowStats()
        {
            Console.WriteLine($"{_Name} doet {_Damage} damage en het type wapen is een {_Type}.");
        }

        public void UpgradeWeapon(int DamageToAdd)
        {
            _Damage += DamageToAdd;
        }

    }
}
