namespace InterfaceExample;

class Program
{
    static void Main(string[] args)
    {
        INotification emailNotification = new EmailNotification("user@example.com");
        INotification smsNotification = new SMSNotification("123-456-7890");

        // Gửi thông báo
        emailNotification.Send("Hello! This is an email notification.");
        smsNotification.Send("Hello! This is an SMS notification.");
    }
}