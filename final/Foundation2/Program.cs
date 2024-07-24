using System;

public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Jim smith", address1);
        Customer customer2 = new Customer("Joseph Prusia", address2);

        // Create products
        Product product1 = new Product("Widget", "A123", 3.5f, 10);
        Product product2 = new Product("Gadget", "B456", 7.0f, 5);
        Product product3 = new Product("Thingamajig", "C789", 12.5f, 2);
        Product product4 = new Product("Doohickey", "D012", 4.0f, 8);
        Product product5 = new Product("Whatchamacallit", "E345", 15.0f, 1);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order detailss
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
    }
}