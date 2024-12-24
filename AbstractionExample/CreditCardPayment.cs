namespace AbstractionExample;

public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }
    
    public CreditCardPayment(double amount, string cardNumber)
        : base(amount)
    {
        CardNumber = cardNumber;
    }
    
    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment of {Amount:C} using card {CardNumber}.");
    }
}