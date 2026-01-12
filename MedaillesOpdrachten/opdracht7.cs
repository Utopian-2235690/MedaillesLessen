using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht7
    {
        public void Opdracht()
        {
            Random randomNumber = new Random();
            int minGetal = 1;
            int maxGetal = 7;

            int number = 0;

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            for (int i = 0; i < 100; i++)
            {
                number = randomNumber.Next(minGetal, maxGetal);
                Console.WriteLine(number);

                if (number == 1)
                {
                    count1++;
                }
                else if (number == 2)
                {
                    count2++;
                }
                else if (number == 3)
                {
                    count3++;
                }
                else if (number == 4)
                {
                    count4++;
                }
                else if (number == 5)
                {
                    count5++;
                }
                else if (number == 6)
                {
                    count6++;
                }
            }
            Console.WriteLine("");

            Console.WriteLine($"Het getal 1 kwam {count1} keren voor.");

            Console.WriteLine($"Het getal 2 kwam {count2} keren voor.");

            Console.WriteLine($"Het getal 3 kwam {count3} keren voor.");

            Console.WriteLine($"Het getal 4 kwam {count4} keren voor.");

            Console.WriteLine($"Het getal 5 kwam {count5} keren voor.");

            Console.WriteLine($"Het getal 6 kwam {count6} keren voor.");
        }
    }
}
