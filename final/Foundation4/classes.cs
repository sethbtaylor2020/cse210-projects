using System;
using System.Collections.Concurrent;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

abstract class Activity
{
    public string Date;
    public int Minutes;

    public Activity(string date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{Date} Activity ({Minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}


class Running : Activity
{
    public int Distance;

    public Running(string date, int minutes, int distance)
        : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (double)Distance / Minutes * 60;
    }

    public override double GetPace()
    {
        return (double)Minutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({Minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}


class Cycling : Activity
{
    public double Speed;
    public double Pace;
    public double Distance;

    public Cycling(string date, int minutes, int speed)
        : base(date, minutes)
    {
        Speed = speed;
        Distance = (Speed * Minutes) / 60.0;
        Pace = 60.0 / Speed;
    }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => Speed;
    public override double GetPace() => Pace;

    public override string GetSummary()
    {
        return $"{Date} Cycling ({Minutes} min): Distance {Distance:0.0} miles, Speed {Speed:0.0} mph, Pace: {Pace:0.0} min per mile";
    }
}



class Swimming : Activity
{
    public int Laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({Minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
