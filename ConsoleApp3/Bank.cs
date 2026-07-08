using System;

class Bank
{
    public int AccountNumber;
    public string? AccountType;
    public double Balance;

    // Default Constructor
    public Bank()
    {
    }

    // Parameterized Constructor
    public Bank(int accountNumber, string accountType, double balance)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Account Type   : " + AccountType);
        Console.WriteLine("Balance        : " + Balance);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Bank b1 = new Bank(101, "Saving", 10000);
        Bank b2 = new Bank();

        b2.AccountNumber = 102;
        b2.AccountType = "Current";
        b2.Balance = 15000;

        b1.Deposit(2000);
        b1.Withdraw(1000);

        b2.Deposit(5000);
        b2.Withdraw(3000);

        Console.WriteLine("First Account");
        b1.Display();

        Console.WriteLine("Second Account");
        b2.Display();
    }
}