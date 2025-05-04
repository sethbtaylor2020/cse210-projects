using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber = -1;

        // Telling the user what to do and the user input //
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        //loop, loop starts here because you dont want to tell them everytime to do this, 
        //we want the loop to tell them to enter a new number everytime//
        while (usernumber != 0)
        {
            // get the numbers to add up //
            Console.WriteLine("Enter a number");
            usernumber = int.Parse(Console.ReadLine());

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        //add the numbers FINALLY
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("The sum is:" + sum);

        //average of the numbers //
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // max number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}
