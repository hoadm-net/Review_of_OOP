namespace PolymorphismExample;

public class Manager : Employee
{
    public int Bonus { get; set; }
    
    public Manager(string name, int baseSalary, int bonus)
        : base(name, baseSalary)
    {
        Bonus = bonus;
    }
    
    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Manager: {Name}, Total Salary: {CalculateSalary():C}");
    }
}