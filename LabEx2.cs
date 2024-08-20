using System;
using System.Text.RegularExpressions; //for regex

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            // wlcome message and introduction
            Console.WriteLine("Welcome to the Average App Calculator!");
            Console.WriteLine("");

            //get student name
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            //get student id
            string studentId;
            while (true)
            {
                Console.Write("Enter your student ID number (Ex. 308116): ");
                studentId = Console.ReadLine();
                if (studentId.Length == 6 && int.TryParse(studentId, out _))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid student ID. Check your format, please enter a 6-digit number.");
                }
            }

            //get program course
            Console.Write("Enter your course: ");
            string course = Console.ReadLine();

            // array to store grades
            double[] grades = new double[8];
            Console.WriteLine("");

            // loop to get grades for each subject 
            for (int i = 0; i < 8; i++)
            {
                while (true)
                {
                    Console.Write($"Enter grade for Subject {i + 1} (format: 90.01): ");
                    string gradeInput = Console.ReadLine();
                    if (double.TryParse(gradeInput, out double grade) && System.Text.RegularExpressions.Regex.IsMatch(gradeInput, @"^\d{2}\.\d{2}$"))
                    {
                        grades[i] = grade;
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade format. Please enter a number in the format (00.00).");
                    }
                }
            }

            //calculate total grade
            double total = 0;
            foreach (double grade in grades)
            {
                total += grade;
            }

            //calculate average grade
            double average = total / 8;
            double roundedAverage = Math.Round(average, 2, MidpointRounding.AwayFromZero);

            // round off average to nearest whole number
            int wholeNumber = (int)average;
            double decimalPart = average - wholeNumber;

            int roundedAverageInt;
            if (decimalPart < 0.5)
            {
                roundedAverageInt = wholeNumber;
            }
            else
            {
                roundedAverageInt = wholeNumber + 1;
            }

            // display results
            Console.WriteLine("");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine("Grades:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {grades[i]:F2}");
            }
            Console.WriteLine($"Total: {total:F2}");
            Console.WriteLine($"Average: {average:F2}");

            // display rounded average and reason
            Console.WriteLine($"The average is {average:F2} so rounded off to {roundedAverageInt}.");
        }
    }
}