using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessageCPD();

        string userNameCPD = PromptUserNameCPD();
        int userNumberCPD = PromptUserNumberCPD();

        int squaredNumberCPD = SquareNumberCPD(userNumberCPD);

        DisplayResultCPD(userNameCPD, squaredNumberCPD);
    }

    static void WelcomeMessageCPD()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserNameCPD()
    {
        Console.Write("Please enter your name: ");
        string nameCPD = Console.ReadLine();

        return nameCPD;
    }

    static int PromptUserNumberCPD()
    {
        Console.Write("Please enter your favorite number: ");
        int numberCPD = int.Parse(Console.ReadLine());

        return numberCPD;
    }

    static int SquareNumberCPD(int numberCPD)
    {
        int squareCPD = numberCPD * numberCPD;
        return squareCPD;
    }

    static void DisplayResultCPD(string nameCPD, int squareCPD)
    {
        Console.WriteLine($"{nameCPD}, the square is {squareCPD}");
    }
}