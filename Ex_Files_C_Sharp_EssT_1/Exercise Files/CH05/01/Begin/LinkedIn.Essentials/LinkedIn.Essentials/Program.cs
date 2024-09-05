// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

ShiftWorker d = new ShiftWorker()
{
    FirstName = "Dynamic",
    LastName = "Worker"
};
d.DaysAvailable = ShiftDays.Wednesday;

//string kid1 = d.Kids[1];
Console.WriteLine(d.DaysAvailable);

var day = DayOfWeek.Monday;
Console.WriteLine(day);

var shiftDay = ShiftDays.Tuesday;
