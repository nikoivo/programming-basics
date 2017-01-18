using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var studentTransport = 0.0;
            var adultTransport = 0.0;
            var stay = nights * 82.99;

            switch (transport.ToLower())
            {
                case "train":
                    if (students + adults >= 50)
                    {
                        adultTransport = 24.99 * 0.5; studentTransport = 14.99 * 0.5;
                    }
                    else
                    {
                        adultTransport = 24.99; studentTransport = 14.99;
                    }
                    break;
                case "bus": adultTransport = 32.50; studentTransport = 28.50; break;
                case "boat": adultTransport = 42.99; studentTransport = 39.99; break;
                case "airplane": adultTransport = 70.0; studentTransport = 50.0; break;
            }

            var total = (adults * adultTransport * 2 + students * studentTransport * 2 + stay) * 1.10;

            Console.WriteLine("{0:f2}", total);
        }
    }
}
