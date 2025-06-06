using System;

public class Writing : Assignment
{
    private string _Prompt;

    public Writing(string studentName, string topic, string prompt)
        : base(studentName, topic)
    {
        _Prompt = prompt;
    }

    public string GetWritingAssignment()
    {
        return $"{_Studentname} here is your writing assignment: {_Prompt}";
    }
}
