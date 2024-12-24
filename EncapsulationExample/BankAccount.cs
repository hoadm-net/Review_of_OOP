namespace EncapsulationExample;

public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    // Read-only property
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double GetBalance()
    {
        return balance;
    }
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive!");
        }
    }
    
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount!");
        }
    }
}