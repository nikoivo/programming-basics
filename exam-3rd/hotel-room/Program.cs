using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());

            if (month == "may" || month == "october")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", ((65.00 * nights) - (65.00 * nights * 0.1)));
                    Console.WriteLine("Studio: {0:f2} lv.", ((50.00 * nights) - (50.00 * nights * 0.3)));
                }
                else if (7 < nights && nights <= 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (65.00 * nights));
                    Console.WriteLine("Studio: {0:f2} lv.", ((50.00 * nights) - (50.00 * nights * 0.05)));
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (65.00 * nights));
                    Console.WriteLine("Studio: {0:f2} lv.", (50.00 * nights));
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", ((68.70 * nights) - (68.70 * nights * 0.1)));
                    Console.WriteLine("Studio: {0:f2} lv.", ((75.20 * nights) - (75.20 * nights * 0.2)));
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (68.70 * nights));
                    Console.WriteLine("Studio: {0:f2} lv.", (75.20 * nights));
                }
            }
            else if (month == "july" || month == "august")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", ((77.00 * nights) - (77.00 * nights * 0.1)));
                    Console.WriteLine("Studio: {0:f2} lv.", (76.00 * nights));
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (77.00 * nights));
                    Console.WriteLine("Studio: {0:f2} lv.", (76.00 * nights));
                }
            }
        }
    }
}
