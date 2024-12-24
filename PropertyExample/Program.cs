namespace PropertyExample;

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng Product
        Product product = new Product("Laptop", 500, 10);

        // Sử dụng Auto-Implemented Property
        product.Name = "Gaming Laptop";

        // Sử dụng Full Property
        product.StockQuantity = 15; // Gán giá trị hợp lệ
        product.StockQuantity = -5; // Gán giá trị không hợp lệ

        // Sử dụng Write-Only Property
        product.SecretCode = "SuperSecret123";

        // Hiển thị thông tin sản phẩm
        product.DisplayInfo();

        // Truy cập Read-Only Property
        Console.WriteLine($"Cost Price (read-only): {product.CostPrice:C}");

    }
}