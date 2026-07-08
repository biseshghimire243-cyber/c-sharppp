using System;

class ProductInfo
{
    public string ProductName;
    public double Price;
    public int Quantity;

    public ProductInfo(string productName, double price, int quantity)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }

    public void ShowProduct()
    {
        Console.WriteLine("Product: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
    }

    public void IncreasePrice(double amount)
    {
        Price += amount;
    }
}

class ProductProgram
{
    static void Main()
    {
        ProductInfo p1 = new ProductInfo("Laptop", 60000, 5);

        p1.ShowProduct();

        Console.WriteLine();

        p1.ProductName = "Gaming Laptop";
        p1.IncreasePrice(5000);

        p1.ShowProduct();
    }
}