using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise___Classes
{
    class Line
    {
        private Point p1 = new Point();
        private Point p2 = new Point();


        //functions

        public Line(Point p1 , Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void setPoints(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double calculateLength()
        {
            double length;
            length = Math.Sqrt(   Math.Pow(p2.getX() - p1.getX() , 2) + Math.Pow(p2.getY() - p1.getY() , 2));
            return length;
        }

    }
}
