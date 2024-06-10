class ListingActivity : Activity
{
    // atributes
    private string[] Listings;
    // constructor
    public ListingActivity():base()
    {
        Console.WriteLine($"Listing Activity: title {_title}, desc {_desc}, duration {_duration}");
    }
}