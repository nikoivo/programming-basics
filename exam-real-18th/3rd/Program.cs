using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var holiday = Console.ReadLine().ToLower();

            var hrizantemaPrice = 0.0;
            var rosePrice = 0.0;
            var tulipPrice = 0.0;
            var totalFlowers = hrizantemi + tulips + roses;
            

            switch (season)
            {
                case "spring": hrizantemaPrice = 2.0; rosePrice = 4.1; tulipPrice = 2.5;break;
                case "summer": hrizantemaPrice = 2.0; rosePrice = 4.1; tulipPrice = 2.5; break;
                case "autumn": hrizantemaPrice = 3.75; rosePrice = 4.5; tulipPrice = 4.15; break;
                case "winter": hrizantemaPrice = 3.75; rosePrice = 4.5; tulipPrice = 4.15; break;
            }
            var totalPrice = hrizantemi * hrizantemaPrice + roses * rosePrice + tulips * tulipPrice;
            if (holiday == "y")
            {
                totalPrice *= 1.15;
            }
            if (tulips > 7 && season == "spring")
            {
                totalPrice *= 0.95;
            }
            if (roses >= 10 && season == "winter")
            {
                totalPrice *= 0.9;
            }
            if (totalFlowers > 20)
            {
                totalPrice *= 0.8;
            }
            Console.WriteLine("{0:f2}",totalPrice +2);
        }
    }
}
