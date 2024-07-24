public class Cycling : Activity
{
    private float speed;

    public Cycling(string date, int minutes, float speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override float GetDistance() => speed * GetMinutes() / 60;
    public override float GetSpeed() => speed;
    public override float GetPace() => 60 / speed;
    public override string GetSummary() =>
        $"{GetDate()} Cycling ({GetMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
}