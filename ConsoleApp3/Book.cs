using System;

class BookInfo
{
    public string Title;
    public string Author;
    public double Price;

    public BookInfo(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void ShowBook()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
    }

    public void IncreasePrice(double amount)
    {
        Price += amount;
    }
}

class BookProgram
{
    static void Main()
    {
        BookInfo b1 = new BookInfo("C# Programming", "John", 800);

        b1.ShowBook();

        Console.WriteLine();

        b1.Title = "Advanced C#";
        b1.IncreasePrice(200);

        b1.ShowBook();
    }
}