using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("One Piece", "Echiro Oda", 1000);



            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error

        }
    }
}
