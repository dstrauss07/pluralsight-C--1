using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dave's Grades");
            book.AddGrade(52.2);
            book.AddGrade(77.6);
            book.AddGrade(92.4);
            var stats =  book.GetStatistics();

        
            Console.WriteLine($"High Grade {stats.High:N2}");
            Console.WriteLine($"Low Grade {stats.Low:N2}");
            Console.WriteLine($"Average {stats.Average:N2}" );
        }
    }
}




