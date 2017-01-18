using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var lily = int.Parse(Console.ReadLine());
            var washerPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var toys = 0;
            var money = 0;

            for (int i = 1; i <= lily; i++)
            {
                if (i % 2 == 0)
                {
                    money += 5*i;
                    money -= 1;
                }
                else
                {
                    toys += 1;
                }
            }
            if (money + (toys * toyPrice) >= washerPrice)
            {
                Console.WriteLine("Yes! {0:f2}",(money + toys * toyPrice) - washerPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}",washerPrice - (money + toys * toyPrice));
            }
        }
    }
}
