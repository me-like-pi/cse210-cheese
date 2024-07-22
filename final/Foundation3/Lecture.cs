public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public new string GetFullDetails() => $"{base.GetFullDetails()}, Speaker: {Speaker}, Capacity: {Capacity}";
}
