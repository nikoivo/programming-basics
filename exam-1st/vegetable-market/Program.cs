using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetable_market
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablePrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegetableKG = int.Parse(Console.ReadLine());
            var fruitKG = int.Parse(Console.ReadLine());

            Console.WriteLine(((vegetablePrice*vegetableKG) + (fruitPrice*fruitKG)) / 1.94);
        }
    }
}
