using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike_race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var track = Console.ReadLine();

            var juniorTax = 0.0;
            var seniorTax = 0.0;
            
            switch (track)
            {
                case "trail": juniorTax = 5.5; seniorTax = 7;
                    break;
                case "cross-country":
                    if (juniors+ seniors >= 50)
                    {
                        juniorTax = 8*0.75;
                        seniorTax = 9.5 * 0.75;
                    }
                    else
                    {
                        juniorTax = 8;
                        seniorTax = 9.5;
                    }
                    break;
                case "downhill": juniorTax = 12.25; seniorTax = 13.75; break;
                case "road": juniorTax = 20; seniorTax = 21.50; break;
            }
            var total = (juniors * juniorTax + seniors * seniorTax) * 0.95;
            Console.WriteLine("{0:f2}",total);
        }
    }
}
