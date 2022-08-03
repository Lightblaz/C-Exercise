using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle() : base()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetLength()
        {
            return length;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }
        public double GetArea()
        {
            return width * length;
        }
        public double GetPerimeter()
        {
            return (width + length) * 2;
        }
        public override string toString()
        {
            return "Rectangle[" + base.ToString() + ", " + "length = " + length + "width = " + width + "]";
        }
    }
}
