using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorLenght = double.Parse(Console.ReadLine());
            var triangleSide = double.Parse(Console.ReadLine());
            var triangleHeight = double.Parse(Console.ReadLine());
            var tilePrice = double.Parse(Console.ReadLine());
            var workerExpenses = double.Parse(Console.ReadLine());
            var area = floorWidth * floorLenght;
            var tileArea = triangleSide * triangleHeight / 2;
            var totalTiles = Math.Ceiling(area / tileArea);
            var actualPrice = (totalTiles + 5) * tilePrice + workerExpenses;

            if (money >= actualPrice)
            {
                Console.WriteLine("{0:f2} lv left.", money - actualPrice);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", actualPrice - money);
            }
        }
    }
}
