// See https://aka.ms/new-console-template for more information
//using LinkedIn.Essentials;
//using System;

string db = LinkedIn.Essentials.Constants.CONFIG_DB_NAME;
Console.WriteLine(db);

Employee e = new Manager();
e.FirstName = "Brian";
Console.WriteLine(e.FirstName);