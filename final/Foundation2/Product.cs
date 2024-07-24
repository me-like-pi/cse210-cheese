using System;

public class Product
{
    private string name;
    private string productID;
    private float pricePerUnit;
    private int quantity;

    public Product(string name, string productID, float pricePerUnit, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string GetName() => name;
    public string GetProductID() => productID;
    public float GetPricePerUnit() => pricePerUnit;
    public int GetQuantity() => quantity;
    public float GetTotalCost() => pricePerUnit * quantity;
}
