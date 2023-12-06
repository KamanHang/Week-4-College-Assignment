public class BankAccount
{
    private string accountNumber;
    private decimal balance = 0;

    public BankAccount(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;

        Console.WriteLine("Your account number is "+accountNumber+" and "+"Your balance is "+balance);
    }



    public decimal Deposit(decimal amount)
    {

        Console.WriteLine("Rs."+amount + " has been deposited in your account");

        return balance += amount;

    }

    public decimal Withdraw(decimal amount)
    {
        Console.WriteLine("Rs." + amount + " has been withrawed from your account");

        return balance -= amount;
    }

    public decimal finalBalance()
    {
        Console.WriteLine("Your Final Balance is  Rs."+balance);
        return balance;
    }
}

