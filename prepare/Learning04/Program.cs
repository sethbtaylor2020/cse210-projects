using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jack Black","History");
        Console.WriteLine(a1.GetTopic());

        Mathassignment a2 = new Mathassignment("Barry Benson","Multiplication","11-13");
        Console.WriteLine(a2.GetTopic());
        Console.WriteLine(a2.GetProblems());

        Writing a3 = new Writing("Mike Smith","History","ww2");
        Console.WriteLine(a3.GetTopic());
        Console.WriteLine(a3.GetWritingAssignment());
    }
}