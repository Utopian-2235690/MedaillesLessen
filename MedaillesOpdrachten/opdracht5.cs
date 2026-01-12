using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht5
    {
        public void Opdracht()
        {
            for (int i = 1; i <11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");


            int number = 5;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(number * i);
            }

            Console.WriteLine("");

            Console.WriteLine("Voer een tafel in.");
            int tafel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tot hoeveel keren wil je door rekenen?");
            int keren = Convert.ToInt32(Console.ReadLine());

            int first = 1;
            int second = tafel;

            for (int i = tafel; i < tafel*(keren+1); i+=tafel)
            {
                Console.WriteLine($"{first}x{second}={i}");
                first++;
            }
        }
    }
}
