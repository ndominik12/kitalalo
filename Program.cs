using System;
using System.Collections.Generic;

namespace kitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szavak = new List<string>
            {
                "fuvola",
                "csirke",
                "adatok",
                "asztal",
                "fogoly",
                "bicska",
                "farkas",
                "almafa",
                "babona",
                "gerinc",
                "dervis",
                "bagoly",
                "ecetes",
                "angyal",
                "boglya"
            };

            Random rnd = new Random();
            string rejtettSzo = szavak[rnd.Next(szavak.Count)];

            char[] talalat = { '.', '.', '.', '.', '.', '.' };
            int tippekSzama = 0;

            while (Array.IndexOf(talalat, '.') != -1)
            {
                string tipp = Console.ReadLine();

                if (tipp == "stop")
                {
                    return;
                }

                if (tipp.Length != 6)
                {
                    Console.WriteLine("Kérlek, pontosan 6 betűs szót adj meg!");
                    continue;
                }

                tippekSzama++;

                for (int i = 0; i < 6; i++)
                {
                    if (tipp[i] == rejtettSzo[i])
                    {
                        talalat[i] = tipp[i];
                    }
                }

                Console.WriteLine(new string(talalat));
            }

            Console.WriteLine(tippekSzama);
        }
    }
}
