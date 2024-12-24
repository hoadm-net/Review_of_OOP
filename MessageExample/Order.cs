namespace MessageExample;

public class Order
{
    public string ProductName { get; private set; }
    public double Amount { get; private set; }

    public Order(string productName, double amount)
    {
        ProductName = productName;
        Amount = amount;
    }
    
    public void DisplayOrderDetails()
    {
        Console.WriteLine($"Order Details: Product - {ProductName}, Amount - {Amount:C}");
    }
}