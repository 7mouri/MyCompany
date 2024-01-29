namespace MyCompany.Engine;

internal abstract class Employee: IEmployee
{
    public string Name { get; set; }
    public string Description { get; set; }

    public int Number { get; set; }
    public Employee()
    {
        Name = string.Empty;
        Description = string.Empty;
    }

    public override string ToString() => GetEmployeeCard();

    public abstract string GetEmployeeCard();

}
