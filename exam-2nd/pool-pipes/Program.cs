using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var pipe1debit = p1 * h;
            var pipe2debit = p2 * h;
            var poolWater = pipe1debit + pipe2debit;

            if (poolWater <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(poolWater/v *100),Math.Truncate(pipe1debit/poolWater*100),Math.Truncate(pipe2debit/poolWater*100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,poolWater - v);
            }
        }
    }
}
