using System;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2024-07-14", 30, 5.0f),
            new Cycling("2024-07-15", 45, 20.0f),
            new Swimming("2024-07-16", 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
