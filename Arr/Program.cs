using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 9, 3,10,5,6,8 };

            for (int i = 4; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("_______________________");
            int x=0;
            while (x < array.Length)
            {
                Console.WriteLine(array[x]);
                x++;
            }
            Console.WriteLine("_______________________");

            //int year = 2001;
            //Console.WriteLine(DateTime.IsLeapYear(year));

            int currentYear = 2001;

            if (currentYear % 400 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }


        }
    }
}
