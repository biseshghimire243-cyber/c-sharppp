using System;

class Keep
{
    public int AccountNumber;
    public string? AccountType;
    public double Balance;

    public Keep(int accountNumber, string accountType, double balance)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        Balance = balance;
    }

    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Type: " + AccountType);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Previous
{
    static void Main()
    {
        Keep b1 = new Keep(101, "Saving", 10000);
        Keep b2 = new Keep(102, "Current", 15000);

        b1.Display();
        Console.WriteLine();

        b2.Display();
    }
}