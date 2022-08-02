using System;
using static Exercise_7.Book;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book b = new Book("4454564", "The old tales", "Jason", "hasonmathed@gmail.com", 4.5);
            Console.WriteLine(b.ToString());
        }
    }
}
