using System;

class Program
{
    static void Main(string[] args)
    {
        //commanded fractions?
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Outputs for commanded fractions
        Console.WriteLine(f1.GetFractionsString());
        Console.WriteLine(f2.GetFractionsString());
        Console.WriteLine(f3.GetFractionsString());
        Console.WriteLine(f4.GetFractionsString());
        f1.SetTop(6);
        f1.SetBottom(7);
        Console.WriteLine(f1.GetFractionsString());
    }
}
