using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BijlesPeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string voorNaam;
            int leeftijd;
            int geboorteJaar;
            Console.Write("Geef uw naam aub ");
            voorNaam = Console.ReadLine();
            Console.WriteLine($"Uw naam is {voorNaam}");
            Console.Write("Wat is uw geboortejaar?");
            geboorteJaar = int.Parse(Console.ReadLine());
            leeftijd = 2022 - geboorteJaar;
            Console.WriteLine($"uw leeftijd is {leeftijd}");
        }
    }
}
