using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var loads = int.Parse(Console.ReadLine());
            var busTons = 0.0;
            var truckTons = 0.0;
            var trainTons = 0.0;
            var totalTons = 0;
            for (int i = 0; i < loads; i++)
            {
                var tonnage = int.Parse(Console.ReadLine());
                if (tonnage <= 3)
                {
                    busTons += tonnage;
                }
                else if (tonnage > 3 && tonnage <= 11)
                {
                    truckTons += tonnage;
                }
                else
                {
                    trainTons += tonnage;
                }
                totalTons += tonnage;
            }
            Console.WriteLine("{0:f2}", (busTons * 200 + truckTons * 175 + trainTons * 120) / totalTons);
            Console.WriteLine("{0:f2}%", busTons * 100 / totalTons);
            Console.WriteLine("{0:f2}%", truckTons * 100 / totalTons);
            Console.WriteLine("{0:f2}%", trainTons * 100 / totalTons);
        }
    }
}
