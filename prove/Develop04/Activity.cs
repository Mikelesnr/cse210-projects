using System;
using System.Diagnostics;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    static int _spinnerCounter = 0;
    static int _duration = 0;


    public Activity()
    {
        _spinnerCounter = _duration = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingtMessage()
    {
        _startingMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        _endingMessage = $"You have completed {_duration} seconds of the {_activityName}.";

        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        DisplaySpinner(5);
        Console.Clear();
    }

    public void DisplaySpinner(int seconds)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < seconds)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        DisplaySpinner(5);
    }

    public void StartActivity()
    {
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayDuration();
        DisplayGetReady();
        Console.Clear();
    }

    public void EndActivity()
    {
        DisplayEndingMessage();
    }

}