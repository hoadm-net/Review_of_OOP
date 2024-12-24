namespace StaticClassExample;

public static class UnitConverter
{
    // Phương thức chuyển đổi Inch sang Centimeter (cm)
    public static double InchToCentimeter(double inches)
    {
        return inches * 2.54;
    }

    // Phương thức chuyển đổi Độ Celsius sang Độ Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Phương thức chuyển đổi Kilogram sang Pound (lb)
    public static double KilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }
}