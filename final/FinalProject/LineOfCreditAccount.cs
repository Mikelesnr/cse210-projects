public class LineOfCreditAccount : BankAccount
{
    public LineOfCreditAccount(int accountNumber) : base(accountNumber)
    {
    }

    public void GetLoan(decimal loanAmount)
    {
        decimal balance = GetBalance();
        decimal newBalance = balance + loanAmount;
        SetBalance(newBalance);
        Console.WriteLine($"Loan of {loanAmount:C} added to account {GetAccountNumber()}.");
    }

    public override void Withdraw(decimal amount) // Polymorphism: specific implementation for line of credit accounts
    {
        decimal balance = GetBalance();
        decimal newBalance = balance - amount;
        SetBalance(newBalance);
    }
}
