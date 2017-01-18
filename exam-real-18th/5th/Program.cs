using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/|\\{0}",new string('.',2*n-1));
            Console.WriteLine("{0}\\|/{0}", new string('.', 2 * n - 1));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',2*n-1-i),new string('-',i));
            }
            Console.WriteLine("{0}",new string('*', 4 * n + 1));
                Console.Write("*");
                for (int r = 0; r < 2*n ; r++)
                {
                Console.Write(".*");
                }
            Console.WriteLine();
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }
    }
}
