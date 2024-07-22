using System;

public class Program
{
    public static void Main()
    {
        Lecture lecture = new Lecture
        {
            Title = "Particles:Part of Your World",
            Description = "A lecture on particle physics.",
            Date = "2024-07-21",
            Time = "10:00 AM",
            Address = "123 Main St",
            Speaker = "John Bob",
            Capacity = 100
        };
        Console.WriteLine($"Lecture: {lecture.GetFullDetails()}");
    }
}