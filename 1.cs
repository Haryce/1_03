using System;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }

    static void Main()
    {
        Product product = new Product
        {
            Name = "Ноутбук",
            Price = 50000,
            Quantity = 10
        };
        System.Console.WriteLine($"Общая стоимость: {product.GetTotalCost()}");
    }
}
