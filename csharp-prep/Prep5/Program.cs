using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program");
        Console.WriteLine("What is your name?");
        string username = Console.ReadLine();

        Console.WriteLine("Whats your favorite number?");
         int favoritenumber = int.Parse(Console.ReadLine());

    
    //Squaring stuff starts :'( //

    
        int square = favoritenumber * favoritenumber;
        Console.WriteLine($"{username} Your Favorite Number Squared is: {square}");

    }
}