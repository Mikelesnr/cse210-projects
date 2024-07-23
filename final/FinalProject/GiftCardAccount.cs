public class GiftCardAccount : BankAccount
{
    public GiftCardAccount(int accountNumber) : base(accountNumber)
    {
    }

    public override void Withdraw(decimal amount) // Polymorphism: specific implementation for gift card accounts
    {
        decimal balance = GetBalance();
        if (amount <= balance)
        {
            decimal newBalance = balance - amount;
            SetBalance(newBalance);
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}