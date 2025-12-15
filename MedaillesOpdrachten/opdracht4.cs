using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht4
    {
        int dagInput;
        int maandInput;
        int jaarInput;

        int dag = 10;
        int maand = 11;
        int jaar = 2025;

        int jaarBerekening = 0;

        public void Opdracht()
        {
            Console.WriteLine("Voer je geboortedag in:");
            dagInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Voer je geboortemaand in:");
            maandInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Voer je geboortejaar in:");
            jaarInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            jaarBerekening = jaar - jaarInput;

            if (maandInput < maand || maandInput == maand && dagInput <= dag)
            {
                Console.WriteLine($"Je bent {jaarBerekening} jaar oud.");
            }
            else if (maandInput == maand && dagInput > dag || maandInput > maand)
            {
                jaarBerekening--;
                Console.WriteLine($"Je bent {jaarBerekening} jaar oud.");
            }

            Stemmen();
            FunFacts();
        }

        public void Stemmen()
        {
            if (jaarBerekening < 18)
            {
                Console.WriteLine("");
                Console.WriteLine("Je mag nog niet stemmen.");

            }
            else if (jaarBerekening >= 18)
            {
                Console.WriteLine("");
                Console.WriteLine("Je mag nu wel stemmen.");
            }
        }

        public void FunFacts()
        {
            if (jaarBerekening >= 18 && jaarBerekening < 20)
            {
                Console.WriteLine("Je bent nog net een tiener!");

            }
            else if (jaarBerekening > 19 && jaarBerekening < 26)
            {
                Console.WriteLine("Je bent nu een jongvolwassen!");
            }
            else if (jaarBerekening > 25 && jaarBerekening < 40)
            {
                Console.WriteLine("Je bent een volwassen persoon!");
            }
        }
    }
}
