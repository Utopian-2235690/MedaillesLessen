using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool admin = false;
            Console.WriteLine("Als je een account wil aanmaken schrijf dan uw naam.");
            string userInputName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Type nu uw wachtwoord in.");
            string userInputPassword = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Type nu ook uw leeftijd in.");
            int userInputAge = Convert.ToInt32(Console.ReadLine());

            if (userInputName.ToLower() == "shiloh")
            {
                admin = true;
            }

            User user1 = new User(userInputName, userInputPassword, userInputAge, 1, admin);
            user1.Login();*/


            /*List<Car> CarList = new List<Car>();
            Car Car1 = new Car("Agila", "Opal", 5);
            CarList.Add(Car1);

            Car Car2 = new Car("Ibiza", "Seat", 5);
            CarList.Add(Car2);

            foreach (Car Car in CarList)
            {
                Car.PrintCarInfo();
            }*/



            /*Opdracht1 opdracht1 = new Opdracht1();
            opdracht1.Opdracht();*/

            /*Opdracht2 opdracht2 = new Opdracht2();
            opdracht2.Opdracht();*/

            /*Opdracht3 opdracht3 = new Opdracht3();
            opdracht3.Opdracht();

            Opdracht4 opdracht4 = new Opdracht4();
            opdracht4.Opdracht();

            Opdracht5 opdracht5 = new Opdracht5();
            opdracht5.Opdracht();

            Opdracht6 opdracht6 = new Opdracht6();
            opdracht6.Opdracht();

            Opdracht7 opdracht7 = new Opdracht7();
            opdracht7.Opdracht();*/


            /*Opdracht8*/
            List<Character> CharacterList = new List<Character>();

            Character karakter1 = new Character("Speler1", 5, 4);
            CharacterList.Add(karakter1);

            Character karakter2 = new Character("Speler2", 8, 1);
            CharacterList.Add(karakter2);

            Character karakter3 = new Character("Speler3", 6, 3);
            CharacterList.Add(karakter3);

            foreach (Character Character in CharacterList)
            {
                Character.ShowStats();
            }


            /*Opdracht9*/
            /*List<Weapon> WeaponList = new List<Weapon>();

            Weapon weapon1 = new Weapon("Gouden prikker", 10, "Prikker");
            WeaponList.Add(weapon1);

            Weapon weapon2 = new Weapon("Speer", 15, "Speer");
            WeaponList.Add(weapon2);

            Weapon weapon3 = new Weapon("Glock", 20, "Geweer");
            WeaponList.Add(weapon3);

            foreach (Weapon Weapon in WeaponList)
            {
                Weapon.ShowStats();
            }

            weapon1.UpgradeWeapon(5);
            weapon2.UpgradeWeapon(5);
            weapon3.UpgradeWeapon(5);

            Console.WriteLine("");
            Console.WriteLine("Wapens zijn geupgrade.");

            foreach (Weapon Weapon in WeaponList)
            {
                Weapon.ShowStats();
            }*/
        }
    }
}
