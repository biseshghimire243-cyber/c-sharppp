using System;

class constructorprogram
{
    public int AccountNumber;
    public string? AccountType;
    public double Balance;

    public constructorprogram(int accountNumber, string accountType, double balance)
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

class Bankkkkk
{
    static void Main()
    {
        constructorprogram b1 = new constructorprogram(101, "Saving", 10000);
        b1.Display();
    }
}