using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter account type (1 for Normal Account, 2 for Exchange Account):");
        int accountType = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter initial balance:");
        decimal initialBalance = decimal.Parse(Console.ReadLine());

        IAccount account;

        if (accountType == 1)
        {
            account = new NormalAccount(initialBalance);
        }
        else if (accountType == 2)
        {
            Console.WriteLine("Enter exchange rate (e.g., 25000 for USD to VND):");
            decimal exchangeRate = decimal.Parse(Console.ReadLine());
            account = new ExchangeAccount(initialBalance, exchangeRate);
        }
        else
        {
            Console.WriteLine("Invalid account type.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Transfer Money");
            Console.WriteLine("3. Exit");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    account.CheckBalance();
                    break;
                case 2:
                    Console.WriteLine("Enter amount to transfer:");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    account.TransferMoney(amount);
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
