using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} zonder rest");
                }
                else
                {
                    Console.WriteLine($"de rest waarde van i is {i % 5}");
                }
            }
        }
    }
}
