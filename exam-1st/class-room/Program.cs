using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var effectiveWidth = h * 100 - 100;
            var rows = (int)(effectiveWidth / 70);
            var columns = (int)( w * 100 / 120);

            Console.WriteLine((rows * columns) - 3);
        }
    }
}
