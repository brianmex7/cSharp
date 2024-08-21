using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix = "")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters

PrintWithPrefix("Hello World");
PrintWithPrefix("Hello World", ">???");



// TODO: Call with named params
PrintWithPrefix(prefix: "%%", thestr: "Hellow World");
