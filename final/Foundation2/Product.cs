public class Product
{
    public string Name { get; set; }
    public string ProductID { get; set; }
    public float PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public string GetName() => Name;
    public string GetProductID() => ProductID;
    public float GetPricePerUnit() => PricePerUnit;
    public int GetQuantity() => Quantity;
    public float GetTotalCost() => PricePerUnit * Quantity;
}