namespace PolymorphismExample;

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Manager("Alice", 5000, 2000),
            new Developer("Bob", 4000, 50, 20),
            new Employee("Charlie", 3000)
        };
        
        foreach (Employee employee in employees)
        {
            employee.DisplayInfo();
        }
    }
}