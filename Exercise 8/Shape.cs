using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Shape
    {
        private string color;
        private bool filled;

        public Shape()
        {
            color = "red";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public bool IsFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public virtual string toString()
        {
            return "Shape[color = " + color + ", " + "filled = " + filled + "]";
        }
    }
}
