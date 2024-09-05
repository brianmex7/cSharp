// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

ShiftWorker d = new ShiftWorker()
{
    FirstName = "Dynamic",
    LastName = "Worker"
};
d.DaysAvailable = ShiftDays.Weekdays;// | ShiftDays.Weekend;
bool availableMonday = d.DaysAvailable.HasFlag(ShiftDays.Monday);
Console.WriteLine($"Available Monday {availableMonday}");

bool availableSaturdays = (d.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;
Console.WriteLine($"Available Saturday {availableSaturdays}");


Console.WriteLine(d.DaysAvailable);

var shiftName = System.Enum.GetNames(typeof(ShiftDays));
Console.WriteLine(string.Join(',', shiftName));

var shiftValues = (short[])System.Enum.GetValues(typeof(ShiftDays));
Console.WriteLine(string.Join(". ", shiftValues));

var day = DayOfWeek.Monday;
//Console.WriteLine(day);
var shiftDay = ShiftDays.Tuesday;
//Console.WriteLine((int)shiftDay);
