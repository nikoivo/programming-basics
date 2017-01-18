using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var playgroundN = int.Parse(Console.ReadLine());
            var tileW = double.Parse(Console.ReadLine());
            var tileL = double.Parse(Console.ReadLine());
            var benchW = int.Parse(Console.ReadLine());
            var benchL = int.Parse(Console.ReadLine());

            var area = (playgroundN * playgroundN) - (benchW * benchL);
            var tileCount = area / (tileL * tileW);

            Console.WriteLine(tileCount);
            Console.WriteLine(tileCount * 0.2);
        }
    }
}
