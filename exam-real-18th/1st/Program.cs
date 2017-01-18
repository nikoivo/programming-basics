using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());
            var secondSpeed = initialSpeed * 1.10;
            var thirdSpeed = secondSpeed * 0.95;
            double total = (initialSpeed * firstTime + secondSpeed * secondTime + thirdSpeed * thirdTime)/60;

            Console.WriteLine("{0:f2}", total);
        }
    }
}
