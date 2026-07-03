using System;

class TotalBalance
{
    static void Main()
    {
        Bank[] accounts = new Bank[5];

        for (int i = 0; i < 5; i++)
        {
            accounts[i] = new Bank();

            Console.Write("Enter Account Number: ");
            accounts[i].AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Type: ");
            accounts[i].AccountType = Console.ReadLine();

            Console.Write("Enter Balance: ");
            accounts[i].Balance = Convert.ToDouble(Console.ReadLine());
        }

        double total = 0;
        double highest = accounts[0].Balance;

        foreach (Bank account in accounts)
        {
            total += account.Balance;
            if (account.Balance > highest)
                highest = account.Balance;
        }

        double average = total / accounts.Length;

        Console.WriteLine("Total Balance = " + total);
        Console.WriteLine("Average Balance = " + average);
        Console.WriteLine("Highest Balance = " + highest);
    }
}