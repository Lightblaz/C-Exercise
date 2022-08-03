using System;
using static Exercise_8.Cat;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("ginger");
            Console.WriteLine(c.toString());
        }
    }
}
