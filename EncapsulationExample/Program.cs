namespace EncapsulationExample;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123-456-789", 5000);
        Console.WriteLine($"Account Number: {account.AccountNumber}");

        // Gửi tiền
        account.Deposit(1500);

        // Rút tiền
        account.Withdraw(2000);

        // Kiểm tra số dư
        Console.WriteLine($"Final Balance: {account.GetBalance():C}");
        
        // Truy cập trực tiếp vào `balance` sẽ không được phép
        // account.balance = 10000; // Lỗi: 'balance' is inaccessible due to its protection level
    }
}