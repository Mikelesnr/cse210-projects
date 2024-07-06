using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by guiding you through slow, mindful breathing. Clear your mind and focus on your breath.");
    }

    public void RunBreathingActivity()
    {
        StartActivity();
        DisplayBreathing();
        EndActivity();
    }

    private void DisplayBreathing()
    {
        int time = GetDuration() * 1000;
        int intervalTime = 10000;
        int intervals = time / intervalTime;

        for (int i = 0; i < intervals; i++)
        {
            Console.Write("Breathe in... ");
            CountUp();
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown();
            Console.WriteLine();
        }
    }

    private void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void CountUp()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
