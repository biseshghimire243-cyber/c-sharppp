using System;

class Bank
{
    public int AccountNumber;
    public string? AccountType;
    public double Balance;

    // Default constructor
    public Bank()
    {
    }

    // Parameterized constructor
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

    public void SeeBalance()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Type: " + AccountType);
        Console.WriteLine("Balance: " + Balance);
    }

    public void Display()
    {
        SeeBalance();
    }
}