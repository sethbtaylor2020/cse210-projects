using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Sean", "Crosby");
        PersonAddress address = new PersonAddress("123 wagon lane", true);
        Order order = new Order(customer, address);

        Product product1 = new Product("Computer", "12345", 100, 1);
        Product product2 = new Product("monitor", "16321", 50, 2);

        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Cost; $"+ order.GetTotalCost());
    }
}