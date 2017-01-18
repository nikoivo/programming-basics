﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', (2 * n + 1) - 2 * i));
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', n - 2 * i));
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', (2 * n + 1) - 2 * i));
            }
        }
    }
}
