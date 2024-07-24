public class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public string GetDate() => date;
    public int GetMinutes() => minutes;
    public virtual float GetDistance() => 0;
    public virtual float GetSpeed() => 0;
    public virtual float GetPace() => 0;
    public virtual string GetSummary() => $"{date} ({minutes} min)";
}