using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n * 2 + 1));
            int dots = n;
            int lines = n * 2 - 1;

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', lines));
                dots--;
                lines += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', n * 2 - 3));

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', lines));
                dots++;
                lines -= 2;
            }
        }
    }
}
