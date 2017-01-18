using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var insideDots = n*3;
            var outsideDots = n - 1;

            Console.WriteLine("{0}{1}{0}",new string('.',n),new string('*',insideDots));
            for(int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDots), new string('.', insideDots));
                outsideDots--;
                insideDots += 2;
            }
            Console.WriteLine("{0}",new string('*',5*n));

            // outsideDots++;
            // insideDots -= 2;

            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDots + 1), new string('.', insideDots - 2));
                outsideDots++;
                insideDots -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n*2 + 1), new string('*', n -2));
        }
    }
}
