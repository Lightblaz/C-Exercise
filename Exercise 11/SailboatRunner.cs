using System;
using static Exercise_11.Captain;

namespace Exercise_11
{
    class SailboatRunner
    {
        static void Main(string[] args)
        {
            Sailboat sailboat = new Sailboat(34, "jerry", "gd&g");
            Console.WriteLine(sailboat.toString());
            Captain cap = new Captain(23, "rasika", 2, 3443);
            sailboat.assignCaption(cap);
            Console.WriteLine(sailboat.toString());
            //Console.WriteLine(cap.toString());
            Console.WriteLine(sailboat.getCaptain().ToString());
        }
    }
}
