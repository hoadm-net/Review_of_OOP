namespace InheritanceExample;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    
    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    
    public override void Start()
    {
        Console.WriteLine($"The car {Brand} is starting with {NumberOfDoors} doors.");
    }
}