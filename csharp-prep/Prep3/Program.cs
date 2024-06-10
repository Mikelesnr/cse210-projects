using System;

class Program
{
    static void Main(string[] args)
    {
        Game();

        Console.Write("Do you want to play again y/n? ");    
        string replay = Console.ReadLine().ToLower();    
        while (replay == "y")
        {
            Game();
            Console.Write("Do you want to play again y/n? ");    
            replay = Console.ReadLine().ToLower(); 
        }
    }
    static void Game()
    {
        Random  randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.Write("Whats the magic number? ");
        int guess = int.Parse(Console.ReadLine());

        int count = 1;
        while (guess != number){
            if (count > 1)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            count++;
        }
        string tries = (count == 1) ? "try" : "tries";
        Console.WriteLine($"You Guessed it in {count} {tries}!");
    }
}