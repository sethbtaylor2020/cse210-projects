using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine("Choose an Option");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listening Activity");

        Console.Write("Enter your choice: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                RunBreathingActivity breathing = new RunBreathingActivity();
                breathing.Execute();
                break;

            case "2":
                RunReflectingActivity reflecting = new RunReflectingActivity();
                reflecting.Execute();
                break;
            case "3":
                RunListeningActivity listening = new RunListeningActivity();
                listening.Execute();
                break;
        }
        
    }
}