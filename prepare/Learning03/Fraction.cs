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

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
public class FractionTwo
{
    private int _topTwo;
    private int _bottomTwo;

    public FractionTwo()
    {
        _topTwo = 5;
        _bottomTwo = 1;
    }

    public FractionTwo(int wholeNumber)
    {
        _topTwo = wholeNumber;
        _bottomTwo = 1;
    }

    public FractionTwo(int topTwo, int bottomTwo)
    {
        _topTwo = topTwo;
        _bottomTwo = bottomTwo;
    }

    public string GetFractionString()
    {
        string text = $"{_topTwo}/{_bottomTwo}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topTwo / (double)_bottomTwo;
    }
}

public class FractionThree
{
    private int _topThree;
    private int _bottomThree;

    public FractionThree()
    {
        _topThree = 3;
        _bottomThree = 4;
    }

    public FractionThree(int wholeNumber)
    {
        _topThree = wholeNumber;
        _bottomThree = 4;
    }

    public FractionThree(int topThree, int bottomThree)
    {
        _topThree = topThree;
        _bottomThree = bottomThree;
    }

    public string GetFractionString()
    {
        string text = $"{_topThree}/{_bottomThree}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topThree / (double)_bottomThree;
    }
}

public class FractionFour
{
    private int _topFour;
    private int _bottomFour;

    public FractionFour()
    {
        _topFour = 1;
        _bottomFour = 3;
    }

    public FractionFour(int wholeNumber)
    {
        _topFour = wholeNumber;
        _bottomFour = 3;
    }

    public FractionFour(int topFour, int bottomFour)
    {
        _topFour = topFour;
        _bottomFour = bottomFour;
    }

    public string GetFractionString()
    {
        string text = $"{_topFour}/{_bottomFour}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topFour / (double)_bottomFour;
    }
}