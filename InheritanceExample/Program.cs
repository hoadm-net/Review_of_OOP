namespace InheritanceExample;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", 2020, 4);
        car.DisplayInfo();
        car.Start();

   
        Bike bike = new Bike("Yamaha", 2024, false);
        bike.DisplayInfo();
        bike.Start();
    }
}