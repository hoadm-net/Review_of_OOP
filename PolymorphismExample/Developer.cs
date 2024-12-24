namespace PolymorphismExample;

public class Developer : Employee
{
    public int OvertimeHours { get; set; }
    public int HourlyRate { get; set; }
    
    public Developer(string name, int baseSalary, int overtimeHours, int hourlyRate)
        : base(name, baseSalary)
    {
        OvertimeHours = overtimeHours;
        HourlyRate = hourlyRate;
    }
    
    public override double CalculateSalary()
    {
        return BaseSalary + (OvertimeHours * HourlyRate);
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Developer: {Name}, Total Salary: {CalculateSalary():C}");
    }
}