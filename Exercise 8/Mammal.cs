using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }

        public override string toString()
        {

            string text = "Mammal: Mammel[" + base.toString() + "]";
            return text;
        }
    }
}
