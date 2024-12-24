namespace PropertyExample;

public class Product
{
    // 1. Auto-Implemented Property
    public string Name { get; set; }

    // 2. Read-Only Property (chỉ có get)
    private double costPrice;
    public double CostPrice
    {
        get { return costPrice; }
    }

    // 3. Write-Only Property (chỉ có set)
    private string secretCode;
    public string SecretCode
    {
        set { secretCode = value; }
    }

    // 4. Full Property (có get và set)
    private int stockQuantity;
    public int StockQuantity
    {
        get { return stockQuantity; }
        set
        {
            if (value >= 0) stockQuantity = value;
            else Console.WriteLine("Stock quantity cannot be negative!");
        }
    }

    // 5. Computed Property (tính toán dựa trên các trường khác)
    public double SellingPrice
    {
        get { return CostPrice * 1.2; } // Tăng 20% so với giá gốc
    }

    // Constructor
    public Product(string name, double costPrice, int stockQuantity)
    {
        Name = name;
        this.costPrice = costPrice; // Được gán trực tiếp trong constructor
        StockQuantity = stockQuantity; // Sử dụng Property để kiểm tra dữ liệu
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Cost Price: {CostPrice:C}");
        Console.WriteLine($"Stock Quantity: {StockQuantity}");
        Console.WriteLine($"Selling Price: {SellingPrice:C}");
    }
}