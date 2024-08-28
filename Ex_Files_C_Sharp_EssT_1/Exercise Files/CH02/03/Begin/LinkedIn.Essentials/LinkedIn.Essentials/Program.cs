// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Employee e = new Employee
{
    FirstName = "Brian",
    LastName = "Bustos",
    EmployeeId = 75,
    StartDate = new DateOnly(2024, 8, 28);
};
Console.WriteLine($"From {e.FirstName}, hello world");
