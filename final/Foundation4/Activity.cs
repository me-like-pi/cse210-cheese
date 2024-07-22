public class Activity
{
    public string Date { get; set; }
    public int Minutes { get; set; }

    public string GetDate() => Date;
    public int GetMinutes() => Minutes;
    public virtual float GetSpeed() => 0;
    public virtual float GetPace() => 0;
    public virtual float GetDistance() => 0;
    public virtual string GetSummary() => $"{Date}, {Minutes} minutes";
}