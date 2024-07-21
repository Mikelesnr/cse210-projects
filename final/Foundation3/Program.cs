using System;

class Program
{
    static void Main(string[] args)
    {
        // Create sample events
        var lecture = new Lecture("Business Conference", "Venture Capitalism", DateTime.Now, TimeSpan.FromHours(10),
            new Address { Street = "123 Main St", City = "Seattle", StateProvince = "WA", Country = "USA" }, "Vhusi Thembekwayo", 100);

        var reception = new Reception("Networking Mixer", "Connect with professionals", DateTime.Now.AddDays(7), TimeSpan.FromHours(18),
            new Address { Street = "55 Orange Grove Road", City = "Chinhoyi", StateProvince = "MashWest", Country = "Zimbabwe" }, "rsvp@example.com");

        var outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy nature", DateTime.Now.AddDays(14), TimeSpan.FromHours(12),
            new Address { Street = "789 Oak Ave", City = "San Francisco", StateProvince = "CA", Country = "USA" }, "Sunny weather expected");

        Console.Clear();
        Console.WriteLine("Standard Details for Lecture:");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine("\nFull Details for Reception:");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("\nFull Details for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }
}