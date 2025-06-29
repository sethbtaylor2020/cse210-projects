using System;
//----------------------------------------Base Class for all Goals-------------------------------------------
public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
//---------------------------------------polymorphism crap------------------------------------------------------
    public abstract int EventPoints();
    public abstract bool IsComplete();
    public abstract string GoalName();
    public abstract string ProgressSave();

    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
}
//-----------------------------end of that crap-------------------------------------------------------------


//-------------------------------------------------------------ETERNAL GOAL----------------------------------------------------------------
public class EternalGoal : Goal
{
    private bool _isComplete;
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }
       public EternalGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int EventPoints()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GoalName()
    {
        return $"[∞] {_name} ({_description})";
    }

    public override string ProgressSave()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}
//----------------------------------------------------------------------------------------------END OF ETERNAL GOAL ----------------------------------------------------------------------------------------------


//----------------------------------------------------------------------------------------------SIMPLE GOAL CRAP----------------------------------------------------------------------------------------------
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int EventPoints()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GoalName()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description})";
    }

    public override string ProgressSave()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}
