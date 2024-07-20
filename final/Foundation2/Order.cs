class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalPrice()
    {
        double totalProductCost = 0;
        foreach (var product in products)
        {
            totalProductCost += product.CalculateTotalCost();
        }

        double shippingCost = customer.LivesInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {customer.GetName()}\nAddress:\n{customer.GetAddress()}";
    }
}
