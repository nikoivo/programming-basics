using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolias = int.Parse(Console.ReadLine());
            var zumbuls = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cacti = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var magnoliaPrice = 3.25;
            var zumbulPrice = 4;
            var rosePrice = 3.5;
            var cactusPrice = 8;
            var totalPrice = (magnolias * magnoliaPrice + zumbulPrice * zumbuls + roses * rosePrice + cacti * cactusPrice)*0.95;

            if (totalPrice >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalPrice - presentPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - totalPrice));
            }
        }
    }
}
