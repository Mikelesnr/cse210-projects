using System;

class Program
{
    static void Main(string[] args)
    {
        // Create sample products
        var product1 = new Product("iPhone 13 Pro", 101, 999.99, 2);
        var product2 = new Product("iPad Air (2024)", 202, 599.99, 1);
        var product3 = new Product("Galaxy S24", 303, 899.99, 3);
        var product4 = new Product("Redmi 10", 404, 199.99, 2);
        var product5 = new Product("Galaxy Tab S8", 505, 299.99, 2);
        var product6 = new Product("Xiaomi Mi 14 Ultra", 606, 1499.99, 2);
        var product7 = new Product("Redmi Note 11", 707, 399.99, 2);


        // Create sample address
        var address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        var address2 = new Address("10 Warwick House", "Harare", "Harare", "Zimbabwe");

        // Create sample customer
        var customer1 = new Customer("James Bond", address1);
        var customer2 = new Customer("Roger Moore", address2);

        // Create orders
        var order1 = new Order(customer1, new Product[] { product1, product2, product3, product4, product5 });
        var order2 = new Order(customer2, new Product[] { product2, product3, product4, product6, product7 });

        // Display results
        Console.Clear();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
    }
}