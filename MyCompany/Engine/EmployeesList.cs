using System.Net.WebSockets;

namespace MyCompany.Engine;

internal class EmployeesList : List<IEmployee>
{
    public void PrintAll() {
        for (int i = 0; i < Count; i++)
        {
            IEmployee emp = this[i];
            string empType = emp is Supervisor ? "Supervisor" : "Employee";
            Console.WriteLine($"{empType} {i + 1} information:");
            Console.WriteLine(this[i]);
        }
    }
}
