using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class User
    {
        private string _name;
        private string _password;
        private int _age;
        private int _id;
        private bool _admin;

        public User(string name, string password, int age, int id, bool admin)
        {
            _name = name;
            _password = password;
            _age = age;
            _id = id;
            _admin = admin;

            Console.WriteLine($"User: {_name} met wachtwoord: {_password} en leeftijd: {_age} is aangemaakt!");

        }

        public void Login()
        {
            Console.Clear();
            if (_admin == true)
            {
                Console.WriteLine($"Hoi admin {_name}, welkom!");
            }
            else
            {
                Console.WriteLine($"Hoi gebruiker {_name}, welkom!");
            }
        }
    }
}
