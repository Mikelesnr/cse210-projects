using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int userMainMenuSelection = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracking App!");
        Console.WriteLine();

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            goalManager.DisplayPoints(goalManager.getTotalPoints());
            Console.WriteLine();
            menu.DisplayMainMenu();
            userMainMenuSelection = int.Parse(Console.ReadLine());
            Console.Clear();

            if (userMainMenuSelection == 1)
            {
                menu.DisplayNewGoalMenu();
                int userNewGoalSelection = int.Parse(Console.ReadLine());
                Console.Clear();
                Goal goal = null;
                if (userNewGoalSelection == 1)
                {
                    goal = new SimpleGoal();
                    goal.DisplayGoalName();
                    goal.DisplayGoalDescription();
                    goal.DisplayGoalPoints();
                }
                else if (userNewGoalSelection == 2)
                {
                    goal = new EternalGoal();
                    goal.DisplayGoalName();
                    goal.DisplayGoalDescription();
                    goal.DisplayGoalPoints();
                }
                else
                {
                    goal = new CheckListGoal();
                    goal.DisplayGoalName();
                    goal.DisplayGoalDescription();
                    goal.DisplayGoalPoints();
                }

                if (goal != null)
                {
                    goalManager.addGoal(goal);
                }
            }
            else if (userMainMenuSelection == 2)
            {
                goalManager.DisplayGoals();
            }
            else if (userMainMenuSelection == 3)
            {
                goalManager.SaveGoals();
            }
            else if (userMainMenuSelection == 4)
            {
                goalManager.LoadGoals();
            }
            else if (userMainMenuSelection == 5)
            {
                goalManager.DisplayGoalRecordEvent();
            }
            else if (userMainMenuSelection == 6)
            {
                Console.Write("Do you want to save before you quit (y/n)? ");
                string userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    goalManager.SaveGoals();
                }

                Console.WriteLine();
                Console.WriteLine("Thank you! Goodbye. ");
            }
            else
            {
                Console.WriteLine("Please select a valid option.");
            }
        }
    }
}
