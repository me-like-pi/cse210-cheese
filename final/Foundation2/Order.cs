public class Order
{
    public List<string> Products { get; set; } = new List<string>();
    public int Customer { get; set; }

    public float GetTotalCost()
    {
        float totalCost = 0;
        foreach (var product in Products)
        {
            Product prod = GetProductByName(product);
            totalCost += prod.GetTotalCost();
        }
        return totalCost;
    }

    public string GetPackingLabel() => $"Customer ID: {Customer}, Products: {string.Join(", ", Products)}";
    public string GetShippingLabel() => $"Customer ID: {Customer}, Shipping Address: {GetCustomerById(Customer).GetAddress()}";

    private Product GetProductByName(string name)
    {
        // Dummy method for illustration
        return new Product();
    }

    private Customer GetCustomerById(int id)
    {
        // Dummy method for illustration
        return new Customer();
    }
}