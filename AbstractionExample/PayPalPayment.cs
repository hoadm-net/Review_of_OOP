namespace AbstractionExample;

public class PayPalPayment : Payment
{
    public string Email { get; set; }
    
    public PayPalPayment(double amount, string email)
        : base(amount)
    {
        Email = email;
    }
    
    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing PayPal payment of {Amount:C} for email {Email}.");
    }
}