namespace AbstractionExample;

public abstract class Payment
{
    public double Amount { get; set; }
    
    public Payment(double amount)
    {
        Amount = amount;
    }
    
    public abstract void ProcessPayment();
    
    public void DisplayPaymentInfo()
    {
        Console.WriteLine($"Processing payment of {Amount:C}.");
    }
}