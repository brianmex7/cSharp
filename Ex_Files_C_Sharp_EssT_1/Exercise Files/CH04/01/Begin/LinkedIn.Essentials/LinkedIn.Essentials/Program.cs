// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;


ShiftWorker e = new ShiftWorker();
e.FirstName = "Hello";
e.ShiftStartTime = new TimeOnly(8, 30);

//e.IsActive();

Console.WriteLine(e.FirstName);