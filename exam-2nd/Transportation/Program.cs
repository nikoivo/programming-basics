using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();
            var distance = 0.0;

            if (n < 20 && timeOfDay == "day")
            {
                distance = 0.7 + n * 0.79;
            }
            else if (n < 20 && timeOfDay == "night")
            {
                distance = 0.7 + n * 0.90;
            }
            else if (n < 100)
            {
                distance = n * 0.09;
            }
            else if (n >= 100)
            {
                distance = n * 0.06;
            }
            Console.WriteLine("{0}",distance);
        }
    }
}
