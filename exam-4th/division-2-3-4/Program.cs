using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var Percent2 = 0.0;
            var Percent3 = 0.0;
            var Percent4 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Percent2++;
                }
                if (num % 3 == 0)
                {
                    Percent3++;
                }
                if (num % 4 == 0)
                {
                    Percent4++;
                }
            }
            Console.WriteLine("{0:f2}%", (Percent2 / n) * 100);
            Console.WriteLine("{0:f2}%", (Percent3 / n)* 100);
            Console.WriteLine("{0:f2}%", (Percent4 / n) * 100);
        }
    }
}
