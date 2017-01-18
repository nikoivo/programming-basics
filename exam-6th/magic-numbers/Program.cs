using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            for (int e = 0; e < 10; e++)
                            {
                                for (int f = 0; f < 10; f++)
                                {
                                    if (a*b*c*d*e*f == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ",a,b,c,d,e,f);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
