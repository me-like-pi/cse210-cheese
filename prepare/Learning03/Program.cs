using System;

class Program
{
    static void Main(string[] args)
    {
        FractionCalculate f1 = new FractionCalculate();
        Console.WriteLine(f1.GetFractionStringCPD());
        Console.WriteLine(f1.GetDecimalValueCPD());

        FractionCalculate f2 = new FractionCalculate(5);
        Console.WriteLine(f2.GetFractionStringCPD());
        Console.WriteLine(f2.GetDecimalValueCPD());

        FractionCalculate f3 = new FractionCalculate(3, 4);
        Console.WriteLine(f3.GetFractionStringCPD());
        Console.WriteLine(f3.GetDecimalValueCPD());

        FractionCalculate f4 = new FractionCalculate(1, 3);
        Console.WriteLine(f4.GetFractionStringCPD());
        Console.WriteLine(f4.GetDecimalValueCPD());
    }
}