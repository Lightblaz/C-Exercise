using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise___Classes
{
    class Point3D : Point
    {
        private int z;

        public Point3D() : base()
        {
            z = 300;
        }

        public Point3D(int x , int y , int z): base(x , y) 
        {
            this.z = z;
        }

        public void setZ(int z) 
        {
            this.z = z;
        }


        public void setZ()
        { 
            setX(1000);
            setY(2000);
            z = 3000;
        }
        public int getZ()
        {
            return z;
        }

        public override void setValues()
        {
            base.setValues();
            z = 3000;
        }

        public override void setValues(int x, int y)
        {
            base.setValues(x, y);
            
        }
    }
}
