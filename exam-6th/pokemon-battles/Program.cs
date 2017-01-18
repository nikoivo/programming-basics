using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon1 = int.Parse(Console.ReadLine());
            var pokemon2 = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 1; i <= pokemon1; i++)
            {
                for (int j = 1; j <= pokemon2; j++)
                {
                    count++;
                    if (count > battles)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                }
            }
        }
    }
}
