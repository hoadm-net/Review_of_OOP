namespace InheritanceExample;

public class Bike : Vehicle
{
    public bool HasGear { get; set; }
    
    public Bike(string brand, int year, bool hasGear)
        : base(brand, year)
    {
        HasGear = hasGear;
    }
    
    public override void Start()
    {
        Console.WriteLine($"The bike {Brand} is starting. Has gear: {HasGear}");
    }
}