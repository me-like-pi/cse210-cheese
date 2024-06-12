using System;
using System.Threading;

public class Timer
{
    private DateTime startTime;
    private TimeSpan duration;

    public Timer(TimeSpan duration)
    {
        this.duration = duration;
        this.startTime = DateTime.Now;
    }

    public void WaitUntilTimeElapsed()
    {
        DateTime futureTime = startTime.Add(duration);
        DateTime currentTime;

        do
        {
            Thread.Sleep(100); // Adjust the sleep interval as needed
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        Console.WriteLine("Time has elapsed!");
    }
}



/*
class Timer
{
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(5);

    Thread.Sleep(3000);

    DateTime currentTime = DateTime.Now;
    if (currentTime < futureTime)
    {
        Console.WriteLine("We have not arrived at our future time yet...")
    }
}
*/