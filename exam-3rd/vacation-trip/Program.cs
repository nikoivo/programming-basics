using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

                if (season == "summer" && budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", budget * 0.3);
            }
            else if (season == "winter" && budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", budget * 0.7);
            }

            else if (season == "summer" && budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", budget * 0.4);
            }
            else if (season == "winter" && budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", budget * 0.8);
            }
            else if (season == "summer" || season == "winter" && budget > 1000 && budget <= 5000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", budget * 0.9);
            }
        }
    }
}
