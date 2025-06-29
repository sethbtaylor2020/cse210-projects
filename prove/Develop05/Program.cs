using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    
    {
        bool running = true;
        while (running)
        Console.WriteLine($"Points: {score}");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.Write("Please Select a Number: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("What type of goal do you want to make?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Please select goal type: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();

                Console.WriteLine("Describe your goal");
                string description = Console.ReadLine();

                Console.WriteLine("How many points is this goal worth?");
                int points = int.Parse(Console.ReadLine());

                Goal goal = new SimpleGoal(name, description, points);
                goals.Add(goal);
            }
        }
        else if (input == "2")
        {
            Console.WriteLine("Your goals:");
            foreach (Goal g in goals)
            {
                Console.WriteLine(g.GoalName()); 
            }
        }
        else if (input == "3")
        {
            List<string> lines = new List<string>();
            lines.Add(score.ToString()); 

            foreach (Goal g in goals)
            {
                lines.Add(g.ProgressSave());
            }

            File.WriteAllLines("goals.txt", lines);
            Console.WriteLine("Goals saved!");
        }
        else if (input == "4")
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                Goal goal = null;

                if (type == "SimpleGoal")
                {
                    goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
                }
                // add EternalGoal and ChecklistGoal loading here too

                if (goal != null)
                {
                    goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded!");
        }
    }
}
