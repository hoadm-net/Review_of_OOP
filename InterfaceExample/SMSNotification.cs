namespace InterfaceExample;

public class SMSNotification : INotification
{
    public string PhoneNumber { get; set; }

    public SMSNotification(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
    
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS to {PhoneNumber}: {message}");
    }
}