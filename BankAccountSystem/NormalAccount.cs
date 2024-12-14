public class NormalAccount : Account
{
    public NormalAccount(decimal initialBalance) : base(initialBalance) { }

    public override void CheckBalance()
    {
        Console.WriteLine($"Your balance: {balance:0.##} VND");
    }

    public override void TransferMoney(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"You transferred {amount:0.##} VND, Your balance: {balance:0.##} VND");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}
