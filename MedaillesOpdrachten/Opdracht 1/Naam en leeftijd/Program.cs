using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naam_en_leeftijd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer jouw naam in:");
            string naam = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Voer jouw leeftijd in:");
            string leeftijd = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Hoi " + naam + ", je bent " + leeftijd + " jaar oud!");
        }
    }
}
