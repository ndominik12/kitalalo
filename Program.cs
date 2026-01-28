using System;
using System.Collections.Generic;

namespace kitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feladat 1: szavak rögzítése
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

        }
    }
}