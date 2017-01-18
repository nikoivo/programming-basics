using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var scheduleHrs = int.Parse(Console.ReadLine());
            var scheduleMins = int.Parse(Console.ReadLine());
            var actualHrs = int.Parse(Console.ReadLine());
            var actualMins = int.Parse(Console.ReadLine());

            int actualTotal = actualMins + (actualHrs * 60);
            int scheduleTotal = scheduleMins + (scheduleHrs * 60);

            if (actualTotal == scheduleTotal)
            {
                Console.WriteLine("On time");
            }
            else if ((scheduleTotal - actualTotal) > 0 && (scheduleTotal - actualTotal) <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", (scheduleTotal - actualTotal));
            }
            else if (actualTotal < scheduleTotal)
            {
                Console.WriteLine("Early");
                if ((scheduleTotal - actualTotal) > 30 && (scheduleTotal - actualTotal) < 60)
                {
                    Console.WriteLine("{0} minutes before the start", (scheduleTotal - actualTotal));
                }
                else if ((scheduleTotal - actualTotal) >= 60)
                {
                    Console.WriteLine("{0}:{1:d2} hours before the start", ((scheduleTotal - actualTotal) / 60), ((scheduleTotal - actualTotal) % 60));
                }
            }
            else if (actualTotal > scheduleTotal)
            {
                Console.WriteLine("Late");
                if ((actualTotal - scheduleTotal) < 60)
                {
                    Console.WriteLine("{0} minutes after the start", (actualTotal - scheduleTotal));
                }
                else if ((actualTotal - scheduleTotal) >= 60)
                {
                    Console.WriteLine("{0}:{1:d2} hours after the start", ((actualTotal - scheduleTotal) / 60), ((actualTotal - scheduleTotal) % 60));
                }
            }
        }
    }
}
