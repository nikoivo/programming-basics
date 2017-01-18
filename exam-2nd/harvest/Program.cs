using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyardSQM = int.Parse(Console.ReadLine());
            var grapesPerSQM = double.Parse(Console.ReadLine());
            var wineLiters = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalWine = (vineyardSQM * grapesPerSQM * 0.4) / 2.5;

            if (totalWine < wineLiters)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineLiters - totalWine));
            }
            else if (totalWine >= wineLiters)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(totalWine - wineLiters),Math.Ceiling((totalWine - wineLiters) / workers));
            }
        }
    }
}
