public abstract class BankAccount
{
    private decimal _balance; // Private attribute

    private int _accountNumber; // Public property

    public BankAccount(int accountNumber)
    {
        _accountNumber = accountNumber;
        _balance = 0; // Initialize the balance
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public abstract void Withdraw(decimal amount); // Abstract method

    public void SetBalance(decimal balance)
    {
        _balance = balance;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public int GetAccountNumber()
    {
        return _accountNumber;
    }

}