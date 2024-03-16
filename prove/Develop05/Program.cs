using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool isApplicationRunning = true;
        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();
        GoalSaver goalSaver = new GoalSaver();
        GoalLoader goalLoader = new GoalLoader();

        while (isApplicationRunning)
        {
            Console.WriteLine($"\nYou currently have {totalPoints} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select an option from the menu: ");
            int userChoice = Int32.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CreateNewGoal(goals);
                    break;
                case 2:
                    ListAllGoals(goals);
                    break;
                case 3:
                    goalSaver.SaveGoalsToFile(goals);
                    break;
                case 4:
                    goalLoader.LoadGoalsFromFile(goals);
                    break;
                case 5:
                    RecordEventAndUpdatePoints(goals, ref totalPoints);
                    break;
                case 6:
                    ExitApplication(ref isApplicationRunning);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("Select the type of Goal:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Enter the goal type: ");
        int goalType = Int32.Parse(Console.ReadLine());

        if (goalType >= 1 && goalType <= 3)
        {
            Goal goal = GoalFactory.CreateGoal(goalType);
            goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please select again.");
        }
    }

    static void ListAllGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("List of Goals:");
        int count = 1;
        foreach (Goal goal in goals)
        {
            goal.DisplayDetails(count);
            count++;
        }
    }

    static void RecordEventAndUpdatePoints(List<Goal> goals, ref int totalPoints)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("Select the goal you accomplished:");
        ListAllGoals(goals);

        Console.Write("Enter the number corresponding to the goal: ");
        int goalIndex = Int32.Parse(Console.ReadLine());

        if (goalIndex >= 1 && goalIndex <= goals.Count)
        {
            int pointsEarned = goals[goalIndex - 1].Complete();
            totalPoints += pointsEarned;
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points. Total points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    static void ExitApplication(ref bool isApplicationRunning)
    {
        Console.WriteLine("Thank you for using the Goal Tracker app. Goodbye!");
        isApplicationRunning = false;
    }
}

class GoalFactory
{
    public static Goal CreateGoal(int type)
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points associated with this goal: ");
        int points = Int32.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                return new SimpleGoal(name, description, points, false);
            case 2:
                return new EternalGoal(name, description, points);
            case 3:
                Console.Write("Enter the number of times the goal needs to be accomplished for a bonus: ");
                int bonusCount = Int32.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points for accomplishing it that many times: ");
                int bonusPoints = Int32.Parse(Console.ReadLine());

                return new CheckListGoal(name, description, points, bonusCount, bonusPoints);
            default:
                return null;
        }
    }
}

