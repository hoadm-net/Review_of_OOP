namespace InterfaceExample;

public class EmailNotification : INotification
{
    public string EmailAddress { get; set; }

    public EmailNotification(string emailAddress)
    {
        EmailAddress = emailAddress;
    }
    
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email to {EmailAddress}: {message}");
    }
}