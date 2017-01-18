using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumria = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var palamud = double.Parse(Console.ReadLine());
            var safrid = double.Parse(Console.ReadLine());
            var midi = int.Parse(Console.ReadLine());

            var price = skumria * 1.6 * palamud + caca * 1.8 * safrid + midi * 7.5;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
