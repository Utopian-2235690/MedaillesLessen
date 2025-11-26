using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class opdracht3
    {
        public void opdracht()
        {
            Console.WriteLine("Wat voor weer is het?");
            Console.WriteLine("Zonnig");
            Console.WriteLine("Regen");
            Console.WriteLine("Bewolkt");
            Console.WriteLine("");

            string weer = Console.ReadLine();
            Console.WriteLine("");

            if (weer == "zonnig" || weer == "Zonnig")
            {
                Console.WriteLine("Wat voor temperatuur is het?");
                int temperatuur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (temperatuur > 19)
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag, geniet van de zon!");
                }
                else if (temperatuur < 20)
                {
                    Console.WriteLine("Je hebt wel een jas nodig vandaag, het is best koud.");
                }
            }
            else if (weer == "regen" || weer == "Regen")
            {
                Console.WriteLine("Wat voor temperatuur is het?");
                int temperatuur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (temperatuur > 19)
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag, maar het wordt wel aangeraden.");
                }
                else if (temperatuur < 20)
                {
                    Console.WriteLine("Je hebt wel een jas nodig vandaag, het is best koud.");
                }
            }
            else if (weer == "bewolkt" || weer == "Bewolkt")
            {
                Console.WriteLine("Wat voor temperatuur is het?");
                int temperatuur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (temperatuur > 19)
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag, geniet van de zon!");
                }
                else if (temperatuur > 14)
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag, maar het wordt wel aangeraden.");
                }
                else if (temperatuur < 15)
                {
                    Console.WriteLine("Je hebt wel een jas nodig vandaag, het is best koud.");
                }
            }
        }
    }
}
