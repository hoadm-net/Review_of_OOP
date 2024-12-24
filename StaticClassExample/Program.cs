namespace StaticClassExample;

class Program
{
    static void Main(string[] args)
    {
        double inches = 12;      // 12 inch
        double celsius = 30;     // 30°C
        double kilograms = 70;   // 70 kg

        // Chuyển đổi Inch sang Centimeter
        Console.WriteLine($"{inches} inches = {UnitConverter.InchToCentimeter(inches)} centimeters");

        // Chuyển đổi Celsius sang Fahrenheit
        Console.WriteLine($"{celsius} Celsius = {UnitConverter.CelsiusToFahrenheit(celsius)} Fahrenheit");

        // Chuyển đổi Kilogram sang Pound
        Console.WriteLine($"{kilograms} kilograms = {UnitConverter.KilogramsToPounds(kilograms)} pounds");
    }
}