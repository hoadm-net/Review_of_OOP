namespace Overview;

public class Car
{
    // Fields (private by default)
        private string brand;
        private string model;
        private int year;
        private double mileage;

        // Properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1885 && value <= DateTime.Now.Year) // Validation
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Year is not valid!");
                }
            }
        }

        public double Mileage
        {
            get { return mileage; }
            set
            {
                if (value >= 0)
                {
                    mileage = value;
                }
                else
                {
                    throw new ArgumentException("Mileage cannot be negative!");
                }
            }
        }

        // Empty constructor
        public Car()
        {
            brand = "Unknown";
            model = "Unknown";
            year = 2020;
            mileage = 0;
        }

        // Parameterized constructor
        public Car(string brand, string model, int year, double mileage)
        {
            this.brand = brand;
            this.model = model;
            this.Year = year; // Use property to validate
            this.Mileage = mileage; // Use property to validate
        }

        // Public method
        public void Drive(double distance)
        {
            if (distance > 0)
            {
                mileage += distance;
                Console.WriteLine($"The car has been driven for {distance} km. Total mileage: {mileage} km.");
            }
            else
            {
                Console.WriteLine("Distance must be positive.");
            }
        }

        // Private method
        private void PrintDetails()
        {
            Console.WriteLine($"Car Details: {brand} {model} ({year}), Mileage: {mileage} km");
        }

        // Public method that uses private method
        public void ShowCarDetails()
        {
            PrintDetails();
            Console.WriteLine();
        }
}