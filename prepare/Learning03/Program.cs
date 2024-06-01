using System;

class Program
{
    static void Main(string[] args)
    {
        FractionCalculate f1 = new FractionCalculate();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        FractionCalculate f2 = new FractionCalculate(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        FractionCalculate f3 = new FractionCalculate(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        FractionCalculate f4 = new FractionCalculate(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}