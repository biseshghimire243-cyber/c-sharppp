using System;

class AccountInfo
{
    public int AccountNumber;
    public string? AccountType;
    public double Balance;

    // Parameterized Constructor
    public AccountInfo(int accountNumber, string accountType, double balance)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        Balance = balance;
    }

    // Display Method
    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Type: " + AccountType);
        Console.WriteLine("Balance: " + Balance);
    }
}

class ConstructorProgram
{
    static void Main()
    {
        AccountInfo a1 = new AccountInfo(101, "Saving", 10000);
        AccountInfo a2 = new AccountInfo(102, "Current", 15000);

        Console.WriteLine("First Account");
        a1.Display();

        Console.WriteLine();

        Console.WriteLine("Second Account");
        a2.Display();
    }
}