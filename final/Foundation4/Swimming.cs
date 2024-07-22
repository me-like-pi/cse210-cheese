public class Swimming : Activity
{
    public int Laps { get; set; }
    public float Distance { get; set; }

    public override float GetSpeed() => Distance / Minutes;
    public override float GetPace() => Minutes / Distance;
    public override float GetDistance() => Distance;
}