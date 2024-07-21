using System;

class Program
{
    static void Main(string[] args)
    {
        // Create sample activities
        var runningActivity = new Running(new DateTime(2022, 11, 3), TimeSpan.FromMinutes(40), 3.5);
        var cyclingActivity = new Cycling(new DateTime(2022, 11, 3), TimeSpan.FromMinutes(55), 25.7);
        var swimmingActivity = new Swimming(new DateTime(2022, 11, 3), TimeSpan.FromMinutes(20), 20);

        // Display summaries
        Console.Clear();
        Console.WriteLine(runningActivity.GetSummary());
        Console.WriteLine(cyclingActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}