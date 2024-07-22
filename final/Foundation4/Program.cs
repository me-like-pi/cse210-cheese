using System;
public class Program
{
    public static void Main()
    {
        Running running = new Running
        {
            Date = "2024-07-14",
            Minutes = 30,
            Distance = 5.0f
        };
        Console.WriteLine($"Running Activity: {running.GetSummary()}, Speed: {running.GetSpeed()} km/h");
    }
}