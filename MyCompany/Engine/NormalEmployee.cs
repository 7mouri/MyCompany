namespace MyCompany.Engine;

internal class NormalEmployee : Employee
{ 
    public override string GetEmployeeCard() => $@"EMP: name: {Name}
Number: {Number}
Description: {Description}";
}
