//Main Class
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and exit");
            Console.WriteLine("Select an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Enter the type of goal (1: Simple, 2: Eternal, 3: List): ");
        int type = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(name, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.WriteLine("Enter the target count for the goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ListGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record (enter number): ");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            int points = goals[goalIndex].RecordEvent();
            totalScore += points;
            Console.WriteLine($"Recorded! You earned {points} points.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string status = goal.GetStatus();
            Console.WriteLine($"{i + 1}. {goal.Name} {status}");
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    static void SaveGoals()
    {
        List<string> lines = new List<string>
        {
            totalScore.ToString()
        };

        foreach (var goal in goals)
        {
            lines.Add(goal.Serialize());
        }

        File.WriteAllLines("goals.txt", lines);
        Console.WriteLine("Goals and score saved.");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            if (lines.Length > 0)
            {
                totalScore = int.Parse(lines[0]);
                goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string type = parts[0];

                    Goal goal = type switch
                    {
                        "SimpleGoal" => new SimpleGoal("", 0),
                        "EternalGoal" => new EternalGoal("", 0),
                        "ListGoal" => new ListGoal("", 0, 0, 0),
                        _ => throw new Exception("Unknown goal type.")
                    };

                    goal.Deserialize(parts);
                    goals.Add(goal);
                }
                Console.WriteLine("Goals and score loaded.");
            }
        }
    }
}
