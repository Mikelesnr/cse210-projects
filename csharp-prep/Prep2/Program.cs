using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade % ");
        int percent = int.Parse(Console.ReadLine());
        string letter = Grade(percent);
        string sign = Symbol(percent);
        string grade = $"{sign}{letter}";
        PrintGrade(grade);
        if(percent >= 70) 
        {
            Console.WriteLine("You passed the class 🎊");
        }
        else{
            Console.WriteLine("You'll make it next time");
        }
    }

    static string Grade(int value)
    {
        if (value >= 90)
        {
            return "A";
        }
        else if (value >= 80)
        {
            return "B";
        }
        else if (value >= 70)
        {
            return "C";
        }
        else if (value >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    static void PrintGrade(string message){
        Console.WriteLine($"Your grade is {message}");
    }

    static string Symbol(int score)
    {
        int lastDigit = score % 10;
        if(score >= 60){
            if(score <= 90 & lastDigit >= 7){
                return "+";
            }
            if(lastDigit < 3){
                return "-";
            }

        }
        return "";
    }
}

