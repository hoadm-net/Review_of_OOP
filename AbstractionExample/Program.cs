namespace AbstractionExample;

class Program
{
    static void Main(string[] args)
    {
        Payment[] payments = new Payment[]
        {
            new CreditCardPayment(100, "1234-5678-9876-5432"),
            new PayPalPayment(250, "user@example.com")
        };
        
        foreach (Payment payment in payments)
        {
            payment.DisplayPaymentInfo();
            payment.ProcessPayment();
            Console.WriteLine();
        }
    }
}