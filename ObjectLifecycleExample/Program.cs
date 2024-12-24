namespace ObjectLifecycleExample;

class Program
{
    static void Main(string[] args)
    {
        // Sử dụng khối using để tự động gọi Dispose
        using (ResourceManager rm = new ResourceManager())
        {
            Console.WriteLine("Working with ResourceManager...");
        }

        // Gọi Dispose thủ công nếu không sử dụng using block
        // ResourceManager rm2 = new ResourceManager();
        // rm2.Dispose();

        Console.WriteLine("Main method completed.");
    }
}