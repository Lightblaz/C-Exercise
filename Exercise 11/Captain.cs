using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_11
{
    class Captain
    {
        private int age;
        private string name;
        private int yearsOfExperience;
        private int registryNumber;

        public Captain(int age , string name , int yearsOfExperience , int registryNumber)
        {
            this.age = age;
            this.name = name;
            this.yearsOfExperience = yearsOfExperience;
            this.registryNumber = registryNumber;
        }

        public string getName()
        {
            return name;
        }

        public int getYearsOfExperience()
        {
            return yearsOfExperience;
        }

        public bool equals(Captain captain)
        {
            if (captain.name == name && (captain.registryNumber == this.registryNumber))
            {
                return true;
            }
            else
            {
                return false;
            }

            /*if(captain == this)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }

        public string toString()
        {

            string text = name + ", age: " + age + "\n" + "YoE: " + yearsOfExperience + "\n" + "Registry: " + registryNumber; 
            return text;
        }
    }
}
