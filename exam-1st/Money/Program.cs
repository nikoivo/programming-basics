using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());

            var yuanToLev = yuan * 0.15 * 1.76;
            var exchange = ((bitcoins * 1168) + yuanToLev) / 1.95;

            Console.WriteLine(exchange - (exchange * comission / 100));
        }
    }
}
