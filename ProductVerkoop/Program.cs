using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductVerkoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product;

            decimal prijs;
            decimal btw;
            decimal prijsMetBtw;
            decimal btwWaarde;

            Console.Write("Geef de product naam aub ");
            product = Console.ReadLine();
            Console.Write("Wat is de prijs ");
            prijs = decimal.Parse(Console.ReadLine());
            Console.Write("Geef de btw in aub ");
            btw = decimal.Parse(Console.ReadLine());
            btwWaarde = prijs * btw /100;
            prijsMetBtw = btwWaarde + prijs;
            Console.WriteLine($"{product} de prijs zonder btw" +
                $"is {prijs} + btw {btwWaarde} = {prijsMetBtw}");

            


        }
    }
}
