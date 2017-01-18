using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalStudents = 0;
            var firstGrade = 0.0;
            var secondGrade = 0.0;
            var thirdGrade = 0.0;
            var fourthGrade = 0.0;
            var totalGrade = 0.0;
            for (int i = 0; i < n; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                totalStudents++;
                totalGrade += grade;
                if (grade >= 5)
                {
                    firstGrade++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    secondGrade++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    thirdGrade++;
                }
                else
                {
                    fourthGrade++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%",(firstGrade/totalStudents)*100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (secondGrade  / totalStudents) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",(thirdGrade / totalStudents) * 100);
            Console.WriteLine("Fail: {0:f2}%",(fourthGrade  / totalStudents) * 100);
            Console.WriteLine("Average: {0:f2}",totalGrade / totalStudents);
        }
    }
}
