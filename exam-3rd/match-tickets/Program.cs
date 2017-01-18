using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var ticket = Console.ReadLine().ToLower();
            var members = int.Parse(Console.ReadLine());

            var ticketMoney = budget;

                        if (members > 0 && members <= 4)
                        {
                            ticketMoney -= budget * 0.75;
                        }
                        else if (members > 4 && members <= 9)
                        {
                ticketMoney -= budget * 0.60;
                        }
                        else if (members > 9 && members <= 24)
                        {
                ticketMoney -= budget * 0.50;
                        }
                        else if (members > 24 && members <= 49)
                        {
                ticketMoney -= budget * 0.40;
                        }
                        else
                        {
                ticketMoney -= budget * 0.25;
                        }
                    
                    if (ticket == "normal")
                        {
                             if ((249.99 * members) < ticketMoney) Console.WriteLine("Yes! You have {0:f2} leva left.",(ticketMoney) - (249.99 * members));
                             else if ((249.99 * members) > ticketMoney) Console.WriteLine("Not enough money! You need {0:f2} leva.",((249.99 * members) - ticketMoney));
                        }
                    else if (ticket == "vip")
            {
                if ((499.99 * members) < ticketMoney) Console.WriteLine("Yes! You have {0:f2} leva left.", (ticketMoney) - (499.99 * members));
                else if ((499.99 * members) > ticketMoney) Console.WriteLine("Not enough money! You need {0:f2} leva.", ((499.99 * members) - ticketMoney));
            }
        }
    }
}
