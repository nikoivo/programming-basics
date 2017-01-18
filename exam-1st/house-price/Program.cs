using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var sqmPrice = double.Parse(Console.ReadLine());
            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;
            var bath = smallestRoom / 2;

            var total = (smallestRoom + secondRoom + thirdRoom + kitchen + bath) * 1.05;
            Console.WriteLine("{0:f2}", total*sqmPrice);
        }
    }
}
