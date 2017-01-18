using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                if ((n1 + n2) % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, operation, n2, n1 + n2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, operation, n2, n1 + n2);
                }
            }
            else if (operation == "-")
            {
                if ((n1 - n2) % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, operation, n2, n1 - n2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, operation, n2, n1 - n2);
                }
            }
            else if (operation == "*")
            {
                if ((n1 * n2) % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, operation, n2, n1 * n2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, operation, n2, n1 * n2);
                }
            }
            else if (operation == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3:n2}", n1, operation, n2,(double)n1 / n2);
                }
            }
            else if (operation == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", n1, operation, n2, n1 % n2);
                }
            }
        }
    }
}
