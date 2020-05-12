using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Jacob's Grade book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"For the book name {book.Name}");
            Console.WriteLine($"The lowest Grade is {stats.Low}");
            Console.WriteLine($"The highest Grade is {stats.High}");
            Console.WriteLine($"The average grade is  {stats.Average}");
            Console.WriteLine($"The Letter grade is  {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {

                Console.WriteLine("Enter a grade or 'q' to quit");
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
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e){
            System.Console.WriteLine("A grade was added");
        }
    }
}
