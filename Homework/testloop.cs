using System;

class Program
{
    static void Main(string[] args)
    

    {
        Console.Write("What is the magic number? ");
        int magicnumber = int.Parse(Console.ReadLine());

        int guess = -1;

        while (guess != magicnumber)

        {
            Console.Write("Guess the magic number. ");
            guess = int.Parse(Console.ReadLine());

                if (guess > magicnumber)
            Console.WriteLine ("Lower");

                else if (guess < magicnumber)
            Console.WriteLine ("Higher");
        }

        {
            Console.WriteLine ("You Guessed it!");
        }
        
    }
}