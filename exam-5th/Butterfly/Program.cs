using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int element = n - 2;

            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', element));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', element));
                }
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', element));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', element));
                }
            }
        }
    }
}
