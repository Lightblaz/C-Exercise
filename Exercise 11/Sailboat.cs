using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_11
{
    class Sailboat
    {
        private int size;
        private string name;
        private string model;
        private Captain captain;


        public Sailboat(int size, String name, String model)
        {
            this.size = size;
            this.name = name;
            this.model = model;
            this.captain = null;
        }

        public bool assignCaption(Captain captain)
        {
            if(this.captain == null)
            {
                this.captain = captain;
                return true;
            }

            if(captain.getYearsOfExperience() > this.captain.getYearsOfExperience())
            {
                this.captain = captain;
                return true;
            }
            return false;
        }

        public Captain getCaptain()
        {
            return captain;
        }

        public bool equals(Sailboat sailboat)
        {
            if(this.captain == null)
            {
                return false;
            }
            if (this.name == sailboat.name && (this.captain == sailboat.getCaptain()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string toString()
        {
            string text = "";
            if(this.getCaptain() == null)
            {
                text = "Relativity is a " + this.size + " feet " + this.model + " " + this.name + " with no captain.";
            }
            else
            {
                text = "Relativity is a " + this.size + " feet " + this.model + " " + this.name + "; Her captain is " + this.captain.getName();
            }
            return text;
        }
    }


}
