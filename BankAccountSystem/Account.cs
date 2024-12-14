public abstract class Account : IAccount
{
    protected decimal balance;

    public Account(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public abstract void CheckBalance();

    public abstract void TransferMoney(decimal amount);
}
