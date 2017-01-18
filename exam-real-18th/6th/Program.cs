using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6th
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = char.Parse(Console.ReadLine());
            var b = char.Parse(Console.ReadLine());
            var c = char.Parse(Console.ReadLine());
            var count = 0;
            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (i == c || j == c || k == c)
                        {
                            continue;
                        }
                        count++;
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
            }
            Console.Write(count);
            Console.ReadLine();
        }
    }
}
