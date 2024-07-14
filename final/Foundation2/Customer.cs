public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }

    public string GetName() => Name;
    public string GetAddress() => Address;
    public bool IsInUSA() => Address.Contains("USA");
}