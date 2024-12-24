namespace MessageExample;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John Doe");
        PaymentProcessor paymentProcessor = new PaymentProcessor();
        customer.PlaceOrder("Laptop", 1200.00, paymentProcessor);
    }
}