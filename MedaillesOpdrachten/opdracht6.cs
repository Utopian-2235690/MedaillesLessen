using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht6
    {
        public void Opdracht()
        {
            Random randomNumber = new Random();
            int minGetal = 1;
            int maxGetal = 6;
            
            bool guessesLeft = true;
            int guesses;
            guesses = 0;

            int answer;
            int number;

            while (guessesLeft)
            {
                number = randomNumber.Next(minGetal, maxGetal);

                Console.WriteLine($"Raad een cijfer tussen {minGetal} tot {maxGetal}");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer > number)
                {
                    Console.Clear();
                    Console.WriteLine("Je hebt het fout geraden, probeer lager te raden.");
                    guesses++;
                }
                else if (answer < number)
                {
                    Console.Clear();
                    Console.WriteLine("Je hebt het fout geraden, probeer hoger te raden.");
                    guesses++;
                }
                else if (answer == number)
                {
                    Console.Clear();
                    Console.WriteLine($"Je hebt het geraden! Het cijfer was {number}.");
                    guessesLeft = false;
                }

                if (guesses == 3)
                {
                    Console.Clear();
                    Console.WriteLine($"Je hebt verloren. Het cijfer was {number}.");
                    guessesLeft = false;
                }
            }
        }
    }
}
