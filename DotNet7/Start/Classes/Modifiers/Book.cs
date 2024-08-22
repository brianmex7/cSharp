using System;

namespace Modifiers
{
    // access modifiers control how properties and methods are accessed
    class Book
    {
        // TODO: "public" members and methods can be accessed by any other code
        // Note: this is *NOT* the right way to expose internal data
        string _name;

        // TODO: "protected" members can only be accessed by the class or a 
        // derived class from this one
        string _author;

        // TODO: "private" is the default and can only be accessed by code 
        // within the class itself
        int _pageCount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pageCount = pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}, {_pageCount} pages";
        }

        // TODO: Member variables can be accessed via methods

    }
}
