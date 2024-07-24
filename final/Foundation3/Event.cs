public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails() => $"{title}, {description}, {date}, {time}, {address.GetFullAddress()}";
    public virtual string GetFullDetails() => $"{title}, {description}, {date}, {time}, {address.GetFullAddress()}";
    public virtual string GetShortDescription() => $"Event: {title}, {date}";
}