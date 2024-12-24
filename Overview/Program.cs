namespace Overview;

class Program
{
    static void Main(string[] args)
    {
        // Using empty constructor
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Model = "Corolla";
        car1.Year = 2020;
        car1.Mileage = 15000;
        car1.ShowCarDetails();

        // Using parameterized constructor
        Car car2 = new Car("Honda", "Civic", 2018, 30000);
        car2.ShowCarDetails();

        // Driving the car
        car2.Drive(500);
    }
}