using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht2
    {
        public void Opdracht()
        {
            Console.WriteLine("Je bent moe, ga naar bed.");
            Console.WriteLine("Je bent nu in de woonkamer, waar wil je naartoe gaan? (Mogelijkheden: gang, voortuin, keuken)");
            string woonkamer = Console.ReadLine();
            Console.WriteLine("");

            if (woonkamer.ToLower() == "gang")
            {
                Console.WriteLine("Je bent nu in de gang, waar wil je naartoe gaan? (Mogelijkheden: achtertuin, trap, wc)");
                string gang = Console.ReadLine();
                Console.WriteLine("");

                if (gang.ToLower() == "achtertuin")
                {
                    Console.WriteLine("Je bent nu in de achtertuin, je kan nergens meer naartoe. Je hebt verloren");
                }
                else if (gang.ToLower() == "wc")
                {
                    Console.WriteLine("Je bent nu in de wc, je kan nergens meer naartoe. Je hebt verloren");
                }
                else if (gang.ToLower() == "trap")
                {
                    Console.WriteLine("Je bent nu op de eerste verdieping, " + 
                        "waar wil je naartoe gaan? (Mogelijkheden: badkamer, slaapkamer, zolder)");

                    string verdieping1 = Console.ReadLine();
                    Console.WriteLine("");

                    if (verdieping1.ToLower() == "badkamer")
                    {
                        Console.WriteLine("Je bent nu in de badkamer, je kan nergens meer naartoe. Je hebt verloren.");
                    }
                    else if (verdieping1.ToLower() == "zolder")
                    {
                        Console.WriteLine("Je bent nu op zolder, je kan nergens meer naartoe. Je hebt verloren.");
                    }
                    else if (verdieping1.ToLower() == "slaapkamer")
                    {
                        Console.WriteLine("Je bent nu in de slaapkamer, wil je naar bed gaan? (Mogelijkheden: slapen)");
                        string slaapkamer = Console.ReadLine();
                        Console.WriteLine("");

                        if (slaapkamer.ToLower() == "slapen")
                        {
                            Console.WriteLine("Je bent nu aan het slapen. Je hebt gewonnen.");
                        }
                    }
                }
            } 
            else if (woonkamer.ToLower() == "voortuin")
            {
                Console.WriteLine("Je bent nu buiten, je kan nergens meer naartoe. Je hebt verloren.");
            }
            else if (woonkamer.ToLower() == "keuken")
            {
                Console.WriteLine("Je bent nu in de keuken, je kan nergens meer naartoe. Je hebt verloren");

            }
        }
    }
}
