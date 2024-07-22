public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string Address { get; set; }

    public string GetStandardDetails() => $"{Title}, {Date}, {Time}, {Address}";
    public string GetFullDetails() => $"{Title}, {Description}, {Date}, {Time}, {Address}";
    public string GetShortDescription() => $"{Title}, {Date}";
}