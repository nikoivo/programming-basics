using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tom_cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());
            var playminutes = (holidays * 127) + ((365 - holidays) * 63);

            if ( playminutes < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",(30000 - playminutes) / 60, (30000 - playminutes) % 60);
            }
            else if (playminutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",(playminutes - 30000) / 60, (playminutes - 30000) % 60);
            }
        }
    }
}
