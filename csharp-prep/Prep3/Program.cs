using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    

    {
        Random magicnumber = new Random();
        int number = magicnumber.Next(1,11);

        int guess = -1;

        while (guess != number)

        {
            Console.Write("Guess the magic number. ");
            guess = int.Parse(Console.ReadLine());

                if (guess > number)
            Console.WriteLine ("Lower");

                else if (guess < number)
            Console.WriteLine ("Higher");
        }

        {
            Console.WriteLine ("You Guessed it!");
        }
        
    }
}