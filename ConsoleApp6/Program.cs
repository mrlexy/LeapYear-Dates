using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        { 
            // January 1, 2007:
            DateTime ty = new DateTime(2018, 8, 4, 15,11,00);
            // Notice how you call IsLeapYear():
            Console.WriteLine(ty);


            Console.WriteLine("Is {0} a leap year? {1}",
           ty, DateTime.IsLeapYear(ty.Year));
            Console.ReadKey();
        }
    }
}
