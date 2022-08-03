using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Dog : Mammal
    {
        public Dog(string name) : base(name) { }

        public void greets()
        {
            Console.WriteLine("Woof");
        }

        public void greets(Dog dog)
        {
            Console.WriteLine("Woooof");
        }

        public override string toString()
        {
            string text = "Dog[" + base.toString() + "]";
            return text;
        }
    }
}
