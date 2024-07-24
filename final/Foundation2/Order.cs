using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    private const float USA_SHIPPING_COST = 5.0f;
    private const float INTERNATIONAL_SHIPPING_COST = 35.0f;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product) => products.Add(product);
    public float GetTotalCost()
    {
        float totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetAddressString()}";
    }
}
