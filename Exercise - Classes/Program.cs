using System;
using static Exercise___Classes.Rectangle;

namespace Exercise___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle r = new Rectangle(1,1,4,1,4,3,1,3);
            //Console.WriteLine(r.calculateArea());
            Console.WriteLine(r.calculatePerimeter());
        }
    }
}
