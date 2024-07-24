public class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override float GetDistance() => laps * 50 / 1000f;
    public override float GetSpeed() => (GetDistance() / GetMinutes()) * 60;
    public override float GetPace() => GetMinutes() / GetDistance();
    public override string GetSummary() =>
        $"{GetDate()} Swimming ({GetMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
}