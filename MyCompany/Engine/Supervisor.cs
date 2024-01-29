namespace MyCompany.Engine;
internal class Supervisor : Employee
{ 
    public override string GetEmployeeCard() => $@"SUP: name: {Name}
    Number: {Number}
    Description: {Description}";
   
}