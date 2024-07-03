using System;
using System.Collections.Generic;

namespace Learning04

{
    class Program
    {
        static void Main(string[] args)
        {
            var assignment = new Assignment("Samuel Bennett", "Multipliction");
            Console.Clear();
            Console.WriteLine(assignment.GetSummary());
            Console.WriteLine("");
            var mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", " 7.3", "8-19");
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());
            Console.WriteLine("");
            var writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInfomation());
        }
    }
}