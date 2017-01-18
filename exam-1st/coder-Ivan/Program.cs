using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coder_Ivan
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var payDay = double.Parse(Console.ReadLine());
            var USDtoBGN = double.Parse(Console.ReadLine());

            var netPay = (14.5 * days * payDay) * 0.75;
            var toBGN = netPay * USDtoBGN;

            Console.WriteLine(Math.Round((toBGN / 365), 2));
        }
    }
}
