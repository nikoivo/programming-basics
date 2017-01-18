using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_to_the_past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var ivan = 17;

            for (int i = 1800; i <= y; i++)
            {
                ivan++;
                if (i % 2 == 0)
                {
                    money -= 12000;
                    
                }
                else
                {
                    money = money - 12000 - (ivan * 50);
                }
            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",money);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(money));
            }
        }
    }
}
