using System;

public class Employee
{
    public Employee(string name, int hours, int rate)
    {
        Name = name;
        Hours = hours;
        Rate = rate;
    }

    public string Name { get; }
    public int Hours { get; }
    public int Rate { get; }

    public int calculatePay()
    {
        return Hours * Rate;
    }

    public int reportHours()
    {
        return Hours;
    }

    public void save()
    {
        Console.WriteLine(Name + " - saved to store.");
    }

}

class TestEmployee
{
    static void Main()
    {
        var employee1 = new Employee("Ryan");
        Console.WriteLine(employee1.Name);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}