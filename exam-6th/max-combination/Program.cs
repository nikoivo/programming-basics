using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b ; j++)
                {
                    count++;
                    if (count > max)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>",i,j);
                }
            }
        }
    }
}
