using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string FirstNameCPD = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string LastNameCPD = Console.ReadLine();
        Console.WriteLine($"Your name is {LastNameCPD}, {FirstNameCPD} {LastNameCPD}.");
    }
}