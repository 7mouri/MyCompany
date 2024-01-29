using MyCompany.Engine;

namespace MyCompany;

internal class Program
{
    static void Main(string[] _)
    {
        Console.WriteLine(  "Welcome to my company");
        Department department = new();
        department.ReadConsole();
        department.Employees.PrintAll();
        Console.WriteLine("Program finished, press return to exit ...");
        Console.ReadLine();
    }
}
