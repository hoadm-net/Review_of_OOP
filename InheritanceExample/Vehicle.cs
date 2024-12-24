namespace InheritanceExample;

public class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }
    
    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
    
    public virtual void Start()
    {
        Console.WriteLine("The vehicle is starting...");
    }
}