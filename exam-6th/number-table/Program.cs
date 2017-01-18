using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_6_number_table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstNum = n / 100;
            var secontNum = (n % 100) / 10;
            var thirdNum = n % 10;
            //Console.WriteLine("{0} {1} {2}",firstNum, secontNum, thirdNum);

            var row = firstNum + secontNum;
            var col = firstNum + thirdNum;
            var num = n;
            for (int i = 0; i < row; i++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (num % 5 == 0)
                    {
                        num -= firstNum;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= secontNum;
                    }
                    else
                    {
                        num += thirdNum;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}