using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersCPD = new List<int>();
        int userNumberCPD = -1;
        while (userNumberCPD != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponseCPD = Console.ReadLine();
            userNumberCPD = int.Parse(userResponseCPD);
            
            // Only add the number to the list if it is not 0
            if (userNumberCPD != 0)
            {
                numbersCPD.Add(userNumberCPD);
            }
        }
        int sumCPD = 0;
        foreach (int numberCPD in numbersCPD)
        {
            sumCPD += numberCPD;
        }

        Console.WriteLine($"The sum is: {sumCPD}");
        float averageCPD = ((float)sumCPD) / numbersCPD.Count;
        Console.WriteLine($"The average is: {averageCPD}");

        int maxCPD = numbersCPD[0];

        foreach (int numberCPD in numbersCPD)
        {
            if (numberCPD > maxCPD)
            {
                // if this number is greater than the max, we have found the new max!
                maxCPD = numberCPD;
            }
        }

        Console.WriteLine($"The max is: {maxCPD}");
    }
}