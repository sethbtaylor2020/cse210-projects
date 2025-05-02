using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("What was your final grade for the class?(number) ");
        string letter_grade = Console.ReadLine();
        int grade = int.Parse(letter_grade);

         if (grade >= 90)
        Console.WriteLine ("You got an A in this class.");

       else if (grade >= 80)
        Console.WriteLine ("You got an B in this class.");

        else if (grade >= 70)
        Console.WriteLine ("You got an C in this class.");

        else if (grade >= 60)
        Console.WriteLine ("You got an D in this class.");

        else
        Console.WriteLine ("You failed this course.");
    }
}