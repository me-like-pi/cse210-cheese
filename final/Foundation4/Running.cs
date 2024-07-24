public class Running : Activity
{
    private float distance;

    public Running(string date, int minutes, float distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override float GetDistance() => distance;
    public override float GetSpeed() => (distance / GetMinutes()) * 60;
    public override float GetPace() => GetMinutes() / distance;
    public override string GetSummary() =>
        $"{GetDate()} Running ({GetMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
}