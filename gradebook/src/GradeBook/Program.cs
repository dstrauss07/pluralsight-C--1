﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dave's Grades");

            //var done = false;


            while (true)
            {
                Console.WriteLine("please enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                        break;
                }
                    try
                    {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    }
                    catch(ArgumentException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch(FormatException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("**");
                    }
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"High Grade {stats.High:N2}");
            Console.WriteLine($"Low Grade {stats.Low:N2}");
            Console.WriteLine($"Average {stats.Average:N2}");
            Console.WriteLine($"The Ltter grade is {stats.Letter}");
        }
    }
}




