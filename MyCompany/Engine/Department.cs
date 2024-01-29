using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Engine;

/// <summary>
/// Handles Department information
/// </summary>
internal class Department
{
    /// <summary>
    /// Constructs new Department class
    /// </summary>
    public Department()
    {
        Name = string.Empty;
        Description = string.Empty;
        Employees = new();
    }

    /// <summary>
    /// Gets or Sets Department name 
    /// </summary>
    public string Name { get; set; }

     public string Description { get; set; }    

    public EmployeesList Employees { get; set; }

    public void ReadConsole() {
        Console.Write("Enter department name:");
        Name = Console.ReadLine() ?? "";
        Console.WriteLine($"You entered department name: {Name}");
        Console.Write("How many employees your department has? ");
        var empCount = int.Parse(Console.ReadLine() ?? "0");
        for (int i = 0; i < empCount; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Getting Employee {i+1} information:");
            Console.Write($"Is employee {i+1} a supervisor (y/n)? ");
            var isSupervisor = (Console.ReadLine() ?? "n").Trim().Equals("y", StringComparison.InvariantCultureIgnoreCase);
            IEmployee employee = isSupervisor? new Supervisor(): new NormalEmployee();
            string empType = isSupervisor ? "supervisor" : "employee";
            Console.Write($"Enter {empType} {i + 1} name:");
            employee.Name = Console.ReadLine() ?? "No Name Entered";
            Console.Write($"Enter {empType} {i + 1} number:");
            employee.Number = int.Parse(Console.ReadLine() ?? "0");
            Console.Write($"Enter {empType} {i + 1} description:");
            employee.Description = Console.ReadLine() ?? "No Description Entered";
            Employees.Add(employee);
        }
    }
  
}
