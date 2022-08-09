using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_12___Doctor
{
    class GeneralPractitioner : Doctor
    {
        private string practiceName;
        private string address;

        public GeneralPractitioner(string practiceName , string address  , string fullName , string registryNumber , string speciality) : base(fullName , registryNumber , speciality)
        {
            this.practiceName = practiceName;
            this.address = address;
        }

        public string toString()
        {
            return base.toString() + " , Practice: " + practiceName;
        }
    }
}
