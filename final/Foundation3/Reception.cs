public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public new string GetFullDetails() => $"{base.GetFullDetails()}, RSVP Email: {RsvpEmail}";
}