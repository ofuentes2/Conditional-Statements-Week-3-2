// Programmer: Omar Fuentes
// Project: Week 3-2
// Date: 01/28/2020
// Description: Welcome to Conditional Statements
using System;

namespace Conditional_Statements_Week_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user about expected grade for the course.
            Console.WriteLine("What is your expected grade for course ISM 4300?");
            Console.WriteLine();

            try
            {
                // Variable.
                int grade = int.Parse(Console.ReadLine());

                // Show error message if user input > 100
                if((grade > 100))
                {
                    Console.WriteLine("Grade cannot exceed 100! Check your input!!");
                }

                // If grade between 98 and 100 the grade will be an A+.
                else if ((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("Letter grade of A+");
                }
                // Otherwise, if grade between 92 and 97 the grade will be an A.
                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("Letter grade of A");
                }
                // Otherwise, if grade between 90 and 91 the grade will be an A-.
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Letter grade of A-");
                }
                // Otherwise, if grade between 92 and 97 the grade will be a B+.
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Letter grade of B+");
                }
                // Otherwise, if grade between 82 and 87 the grade will be a B.
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Letter grade of B");
                }
                // Otherwise, if grade between 80 and 81 the grade will be an B-.
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Letter grade of B-");
                }
                // Otherwise, if grade between 78 and 79 the grade will be an C+.
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Letter grade of C+");
                }
                // Otherwise, if grade between 72 and 77 the grade will be an C.
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Letter grade of C");
                }
                // Otherwise, if grade between 70 and 71 the grade will be an C-.
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Letter grade of C-");
                }
                // Otherwise, if grade below a 70, notify the user is failing.
                else if ((grade < 70))
                {
                    Console.WriteLine("GRADE NOT ACCEPTABLE, YOU ARE FALLING! ORGANIZE YOURSELF!!");
                }                
            }
            // Show user about the acceptable range and how to exit.
            catch
            {
                Console.WriteLine("The values must not be less than 0 and not exceed 100");
                Console.WriteLine("Press ESC to exit");
            }
        }
    }
}

