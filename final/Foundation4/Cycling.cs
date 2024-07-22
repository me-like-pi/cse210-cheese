public class Cycling : Activity
{
    public float Speed { get; set; }

    public override float GetSpeed() => Speed;
    public override float GetPace() => Minutes / (Speed * Minutes);
    public override float GetDistance() => Speed * Minutes;
}