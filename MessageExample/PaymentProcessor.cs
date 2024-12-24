namespace MessageExample;

public class PaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing payment...");
        order.DisplayOrderDetails();
        Console.WriteLine("Payment successful!");
    }

}