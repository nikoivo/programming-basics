using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var to200num = 0.0;
            var to400num = 0.0;
            var to600num = 0.0;
            var to800num = 0.0;
            var over800num = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    to200num++;
                }
                if (num >=200 && num < 400)
                {
                    to400num++;
                }
                if (num >=400 && num < 600)
                {
                    to600num++;
                }
                if (num >= 600 && num < 800)
                {
                    to800num++;
                }
                if (num >= 800)
                {
                    over800num++;
                }
            }
            Console.WriteLine("{0:f2}%", (to200num / n) * 100);
            Console.WriteLine("{0:f2}%", (to400num / n) * 100);
            Console.WriteLine("{0:f2}%", (to600num / n) * 100);
            Console.WriteLine("{0:f2}%", (to800num / n) * 100);
            Console.WriteLine("{0:f2}%", (over800num / n) * 100);
        }
    }
}
