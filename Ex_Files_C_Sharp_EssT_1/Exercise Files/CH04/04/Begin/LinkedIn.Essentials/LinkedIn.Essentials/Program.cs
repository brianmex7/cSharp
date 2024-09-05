// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

dynamic d = new ShiftWorker() { FirstName = "Brian", LastName = "Bustos" };

Console.WriteLine(d.FirstName);