using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var turtleFood = double.Parse(Console.ReadLine());

            var total = (dogFood + catFood + (turtleFood / 1000)) * days;

            if (total <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - total));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(total - food));
            }
        }
    }
}
