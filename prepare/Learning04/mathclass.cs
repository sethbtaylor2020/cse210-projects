using System;

//-------------------------------Math Assignment Class--------------------
public class Mathassignment : Assignment
{
    public string _Problems;

    // Constructor
    public Mathassignment(string Studentname, string topic, string Problems)
        : base(Studentname, topic)
    {
        _Problems = Problems;
    }

    // Method to get problems
    public string GetProblems()
    {
        return $"{_Studentname} here is your problems {_Problems}";
    }
}
