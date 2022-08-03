using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Cat : Mammal
    {

        public Cat(string name): base(name) { }
        public void greets()
        {
            Console.WriteLine("Meow");
        }

        public override string toString()
        {

            string text = "Cat[" + base.toString() + "]";
            return text;
        }
    }
}
