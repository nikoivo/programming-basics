using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var middle = (2 * n) - 2 * (n / 2) - 4;
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2),new string('_', middle));
            for (int i = 1; i <= n -2; i++)
            {
                if (i != n -2 )
                {
                    Console.WriteLine("|{0}|", new string(' ', 2*n - 2));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 +1), new string('_', middle));
                } 
            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ',middle));
        }
    }
}
