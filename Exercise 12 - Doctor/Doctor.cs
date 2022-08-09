using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_12___Doctor
{
    class Doctor
    {
        //declare
        string fullName;
        string registryNumber;
        string specialty;

        public Doctor(string fullName, string registryNumber, string specialty)
        {
            this.fullName = fullName;
            this.registryNumber = registryNumber;
            this.specialty = specialty;
        }
        public string GetName()
        {
            return fullName;
        }
        public string GetRegistryNumber()
        {
            return registryNumber;
        }
        public string GetSpecialty()
        {
            return specialty;
        }
        public void SetName(string fullName)
        {
            this.fullName = fullName;
        }
        public bool Equals(Doctor doctor)
        {
            if (this.registryNumber == doctor.registryNumber)
            {
                return true;
            }

            return false;
        }
        public string toString()
        {
            return "Dr. " + fullName + ", Specialty : " + specialty;
        }
    }
}
