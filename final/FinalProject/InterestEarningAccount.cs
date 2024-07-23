public class InterestEarningAccount : BankAccount
{
    public InterestEarningAccount(int accountNumber) : base(accountNumber)
    {
    }

    public override void Withdraw(decimal amount) // Polymorphism: specific implementation for interest-earning accounts
    {
        decimal balance = GetBalance();
        decimal newBalance = balance - amount;
        SetBalance(newBalance);
    }
}
