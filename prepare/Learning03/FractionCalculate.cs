using System;

public class FractionCalculate
{
    private int _topCPD;
    private int _bottomCPD;

    public FractionCalculate()
    {
        // Default to 1/1
        _topCPD = 1;
        _bottomCPD = 1;
    }

    public FractionCalculate(int wholeNumberCPD)
    {
        _topCPD = wholeNumberCPD;
        _bottomCPD = 1;
    }

    public FractionCalculate(int topCPD, int bottomCPD)
    {
        _topCPD = topCPD;
        _bottomCPD = bottomCPD;
    }

    public string GetFractionStringCPD()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string textCPD = $"{_topCPD}/{_bottomCPD}";
        return textCPD;
    }

    public double GetDecimalValueCPD()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_topCPD / (double)_bottomCPD;
    }
}