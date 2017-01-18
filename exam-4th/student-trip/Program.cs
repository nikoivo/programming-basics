using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());
            var total = 0;
            var carStudents = 0.0;
            var busStudents = 0.0;
            var smallBusStudents = 0.0;
            var bigBusStudents = 0.0;
            var trainStudents = 0.0;


            for (int i = 1; i <= groups; i++)
            {
                var students = int.Parse(Console.ReadLine());
                total += students;
                if (students <= 5)
                {
                    carStudents += students;
                }
                else if (students > 5 && students <= 12)
                {
                    busStudents += students;
                }
                else if (students > 12 && students <= 25)
                {
                    smallBusStudents += students;
                }
                else if (students > 25 && students <= 40)
                {
                    bigBusStudents += students;
                }
                else
                {
                    trainStudents += students;
                }
            }
            Console.WriteLine("{0:f2}%", (carStudents * 100) / total);
            Console.WriteLine("{0:f2}%", (busStudents * 100) / total);
            Console.WriteLine("{0:f2}%", (smallBusStudents * 100) / total);
            Console.WriteLine("{0:f2}%", (bigBusStudents * 100) / total);
            Console.WriteLine("{0:f2}%", (trainStudents * 100) / total);
        }
    }
}
