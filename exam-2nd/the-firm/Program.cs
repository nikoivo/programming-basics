using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var overtime = int.Parse(Console.ReadLine());

            var totalTime = Math.Floor(((days * 8 * 0.9) + (overtime * days * 2)));

            if (totalTime >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", (totalTime - hours));
            }
            else if (totalTime < hours)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", (hours - totalTime));
            }
        }
    }
}
