using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private readonly List<string> _prompts;
    private readonly List<string> _questions;

    public ReflectingActivity() : base()
    {
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. It encourages recognizing your power and applying it in other aspects of life.");

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflectingActivity()
    {
        StartActivity();
        DisplayRandomPrompt();
        DisplayRandomQuestions();
        EndActivity();
    }

    private void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();

        Console.WriteLine("Press enter when you're ready to continue.");
        Console.ReadLine();
    }

    private void DisplayRandomQuestions()
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _questions.Count);
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _questions.Count);
            }
            indexes.Add(randomInt);
        }

        Console.Clear();
        Console.WriteLine("Now reflect on each of the following questions related to your experience:");
        Console.WriteLine();
        DisplayCountdown(5);

        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            DisplaySpinner(GetDuration() / indexes.Count);
            Console.WriteLine();
        }
    }
}
