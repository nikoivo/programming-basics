﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',(n+n/2)-1-i),new string(' ',2*i));
            }
            Console.WriteLine("{0}{1}{0}",new string('.',n/2),new string('*',2*n));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', 2 * n-2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.',n/2-i),new string('*',2*n-2 +2*i));
            }
        }
    }
}
