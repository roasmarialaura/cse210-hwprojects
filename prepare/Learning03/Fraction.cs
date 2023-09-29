using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    //Constructors

    public Fraction()
    {  
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Methods
    public string GetFractionString()
    {
        string fractionFormat = $"{_top}/{_bottom}";
        return fractionFormat;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}
