using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise___Classes
{
    class Rectangle
    {

        private Point p1 = new Point();
        private Point p2 = new Point();
        private Point p3 = new Point();
        private Point p4 = new Point();




        //functions
        public Rectangle(int x1 , int y1 , int  x2 , int y2 , int x3 , int y3 , int x4 , int y4)
        {
            p1.setX(x1);
            p1.setY(y1);
            p2.setX(x2);
            p2.setY(y2);
            p3.setX(x3);
            p3.setY(y3);
            p4.setX(x4);
            p4.setY(x4);
        }

        public void SetPoints(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            p1.setX(x1);
            p1.setY(y1);
            p2.setX(x2);
            p2.setY(y2);
            p3.setX(x3);
            p3.setY(y3);
            p4.setX(x4);
            p4.setY(x4);
        }

        public double calculateArea()
        {
            Line l = new Line(p1 , p2);
            double width = l.calculateLength();
            l.setPoints(p2, p3);
            double height = l.calculateLength();
            return height * width;
        }

        public double calculatePerimeter()
        {
            Line l = new Line(p1, p2);
            double width = l.calculateLength();
            l.setPoints(p2, p3);
            double height = l.calculateLength();
            return (height + width)*2;
        }

    }
}
