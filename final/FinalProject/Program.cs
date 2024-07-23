using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var interestAccount = new InterestEarningAccount(1001);
        interestAccount.Deposit(1000);
        interestAccount.Withdraw(200);

        var creditAccount = new LineOfCreditAccount(2001);
        creditAccount.Deposit(500);
        creditAccount.GetLoan(1000); // Get a loan of $1000
        creditAccount.Withdraw(300);

        var giftCardAccount = new GiftCardAccount(3001);
        giftCardAccount.Deposit(250);
        giftCardAccount.Withdraw(100);

        Console.WriteLine($"Interest Account Balance: {interestAccount.GetBalance()}");
        Console.WriteLine($"Credit Account Balance: {creditAccount.GetBalance()}");
        Console.WriteLine($"Gift Card Account Balance: {giftCardAccount.GetBalance()}");
    }
}