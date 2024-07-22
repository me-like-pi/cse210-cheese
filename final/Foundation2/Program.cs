using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Foundation2 World!");

        Product product = new Product
        {
            Name = "cheese",
            ProductID = "54648",
            PricePerUnit = 5.99f,
            Quantity = 2
        };
        Console.WriteLine($"Product: {product.GetName()}, Total Cost: {product.GetTotalCost()}");
    }
}
