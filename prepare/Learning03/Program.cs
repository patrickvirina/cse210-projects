using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine("Fraction:");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine("Decimal Value:");
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine();

        FractionTwo f2 = new FractionTwo();
        Console.WriteLine("Fraction:");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine("Decimal Value:");
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine();

        FractionThree f3 = new FractionThree();
        Console.WriteLine("Fraction:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine("Decimal Value:");
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine();

        FractionFour f4 = new FractionFour();
        Console.WriteLine("Fraction:");
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine("Decimal Value:");
        Console.WriteLine(f4.GetDecimalValue());

    }
}