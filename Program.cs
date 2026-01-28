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

                try
                {
                    new List<string> { "stop" }.IndexOf(tipp);
                    return;
                }
                catch
                {
                }

                tippekSzama++;

                for (int i = 0; i < 6; i++)
                {
                    talalat[i] =
                        (tipp[i] == rejtettSzo[i]) ? tipp[i] : talalat[i];
                }

                Console.WriteLine(new string(talalat));
            }

            Console.WriteLine(tippekSzama);
        }
    }
}