using Essentials2.Library;

var c = new Customer
{
    Id = 7,
    FirstName = "customer",
    LastName = "first",
    CreateDate = new DateOnly(2022, 1, 17)

};

var c2 = new Customer
{
    Id = 3,
    FirstName = "customer",
    LastName = "second",
    CreateDate = new DateOnly(2022, 1, 17)

};

var sorter = new Sorter<Customer>();
var customers = new Customer[] { c, c2 };
sorter.Sort(customers);
foreach (var customer in customers)
{
    Console.WriteLine($"{customer.Id}: {customer.LastName}");
}


var mapper = new CustomerToPersonMapper();
var p = c.Map<Person>(mapper);// mapper.Map(c);

Console.WriteLine(p.FirstName);

string[] names = new string[2];
names[0] = "John";
names[1] = "Brian";

Console.WriteLine("Hello {0} {1}", names);

var al = new System.Collections.ArrayList(2);
al.Add("First");
al.AddRange(new string[] { "Second", "Third", "Fourth" });

Console.WriteLine($"Collection size is : {al.Count}");
Console.WriteLine("Indexed item from collection [2]: {0}", al[2]);

Console.WriteLine("All items in the list:");

foreach (var item in al)
{
    Console.WriteLine(item);
}