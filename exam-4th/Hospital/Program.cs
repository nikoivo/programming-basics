using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var doctors = 7;
            var untreatedPatients = 0;
            var treatedPatients = 0;

            for (var i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }
                if (number > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += number - doctors;
                }
                else
                {
                    treatedPatients += number;
                }
            }
            Console.WriteLine("Treated patients: {0}.",treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
