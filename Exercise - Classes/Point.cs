using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise___Classes
{
    class Point
    {
        protected int x;
        protected int y;



        //functions
        public Point()
        {
            x = 100;
            y = 200;
        }

        public Point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;

        }

        public virtual void setValues()
        {
            x = 1000;
            y = 2000;
        }


        public virtual void setValues(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
