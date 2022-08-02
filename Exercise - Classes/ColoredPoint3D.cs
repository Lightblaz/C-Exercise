using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise___Classes
{
    class ColoredPoint3D : Point3D
    {
        public string color;


        //functions
        public ColoredPoint3D() : base()
        {
            color = "Red";
        }

        public ColoredPoint3D(int x , int y , int z , string color) : base(x , y , z)
        {
            this.color = color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }
    }
}
