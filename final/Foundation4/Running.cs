public class Running : Activity
{
    public float Distance { get; set; }

    public override float GetSpeed() => Distance / Minutes;
    public override float GetPace() => Minutes / Distance;
    public override float GetDistance() => Distance;
}