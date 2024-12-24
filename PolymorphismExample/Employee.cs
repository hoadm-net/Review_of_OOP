namespace PolymorphismExample;

public class Employee
{
    public string Name { get; set; }
    public int BaseSalary { get; set; }
    
    public Employee(string name, int baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }
    
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Base Salary: {BaseSalary:C}");
    }
}