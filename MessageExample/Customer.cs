namespace MessageExample;

public class Customer
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }
    
    public void PlaceOrder(string productName, double amount, PaymentProcessor paymentProcessor)
    {
        Console.WriteLine($"{Name} is placing an order for: {productName}");
        
        Order order = new Order(productName, amount);
        paymentProcessor.ProcessPayment(order);
    }
}