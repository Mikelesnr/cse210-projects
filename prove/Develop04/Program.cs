using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingActivityCount = 0;
        int reflectionActivityCount = 0;
        int listingActivityCount = 0;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine();

                if (choice == 1)
                {
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breathingActivityCount++;
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.RunReflectingActivity();
                    reflectionActivityCount++;
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listingActivityCount++;
                }
                else if (choice == 4)
                {
                    running = false;
                    Console.WriteLine("Great job! You completed the following activities: ");
                    Console.WriteLine($"Breathing Activity: {breathingActivityCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectionActivityCount} times");
                    Console.WriteLine($"Listing Activity: {listingActivityCount} times");
                    Console.WriteLine();
                    Console.WriteLine("Thank you. Have a nice day!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose one of the following activities.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
