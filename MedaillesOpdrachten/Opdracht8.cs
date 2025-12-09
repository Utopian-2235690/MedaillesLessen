using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Character
    {
        private string _Name;
        private int _Level;
        private int _Lives;

        public Character (string Name, int Level, int Lives)
        {
            _Name = Name;
            _Level = Level;
            _Lives = Lives;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Naam: {_Name}");
            Console.WriteLine($"Level: {_Level}");
            Console.WriteLine($"Lives: {_Lives}");
            Console.WriteLine("");
        }
    }
}
