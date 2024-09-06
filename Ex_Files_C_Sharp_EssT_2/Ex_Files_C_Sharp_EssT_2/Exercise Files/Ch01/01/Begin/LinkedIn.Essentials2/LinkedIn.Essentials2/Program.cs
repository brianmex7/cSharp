// See https://aka.ms/new-console-template for more information
using Essentials2.Library;

int x = 5, y = 7;
Swap<int>(ref x, ref y);
Console.WriteLine($"X: {x} and Y: {y}");
static void Swap<T>(ref T first, ref T second)
{
    T temp = second;
    second = first;
    first = temp;
}

var p1 = new Person
{
    FirstName = "Brian",
    LastName = "Bustos",
    Age = 27
};

var p2 = new Person
{
    FirstName = "Carter",
    LastName = "Marcell",
    Age = 80
};

Swap<Person>(ref p1, ref p2);

Console.WriteLine($"person 1 is {p1.FirstName}");