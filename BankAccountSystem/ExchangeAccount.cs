public class ExchangeAccount : Account
{
    private decimal exchangeRate;

    public ExchangeAccount(decimal initialBalance, decimal exchangeRate) : base(initialBalance)
    {
        this.exchangeRate = exchangeRate;
    }

    public override void CheckBalance()
    {
        decimal balanceInVND = balance * exchangeRate;
        Console.WriteLine($"Your balance: {balanceInVND:0.##} VND");
    }

    public override void TransferMoney(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            decimal transferredAmountInVND = amount * exchangeRate;
            Console.WriteLine($"You transferred {transferredAmountInVND:0.##} VND, Your balance: {balance:0.##} USD");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}
