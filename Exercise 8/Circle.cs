using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Circle : Shape
    {
        private double radius;


        public Circle() : base()
        {
            radius = 1.0;
        }
        public Circle(double radius) : base()
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return 3.14 * radius * radius;
        }
        public double GetPerimeter()
        {
            return 2 * 3.14 * radius;
        }
        public override string toString()
        {
            return "Circle[" + base.toString() + "]"; 
        }
    }
}
