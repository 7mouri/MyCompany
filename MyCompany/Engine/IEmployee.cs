namespace MyCompany.Engine
{
    internal interface IEmployee
    {
        string Description { get; set; }
        string Name { get; set; }
        int Number { get; set; }

        string ToString();


        string GetEmployeeCard();
    }
}