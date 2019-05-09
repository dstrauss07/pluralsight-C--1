using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades =  new List<double>() {12.7,10.3,6.11,4.1};
            grades.Add(52.2);
            var result = 0.0;
            foreach(var number in grades)
            {
                result += number; 
            }
            Console.WriteLine($"total score {result:N1}");
            Console.WriteLine($"Average {result/ grades.Count:N3}" );
            Console.WriteLine("Student " + args[0]);


        }
    }
}
