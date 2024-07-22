public class OutdoorGathering : Event
{
    public string Weather { get; set; }

    public new string GetFullDetails() => $"{base.GetFullDetails()}, Weather: {Weather}";
}