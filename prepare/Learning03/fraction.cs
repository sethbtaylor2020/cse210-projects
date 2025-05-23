using System;

public class Fraction
{
    private int _top;
    private int _bottom;



    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int value)
    {
        _top = value;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int value)
    {
        _bottom = value;
    }

    //returning values

    public string GetFractionsString()
    {
        return $"{_top}/{_bottom}";
    }
}