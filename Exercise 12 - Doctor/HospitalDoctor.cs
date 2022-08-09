using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_12___Doctor
{
    class HospitalDoctor : Doctor
    {
        private string staffNumber;
        private string pagerNumber;

        public HospitalDoctor(string staffNumber, string pagerNumber , string fullName, string registryNumber, string specialty) : base(fullName, registryNumber, specialty)
        {
            this.staffNumber = staffNumber;
            this.pagerNumber = pagerNumber;
        }

        public string toString()
        {
            return base.toString() + " pager : " + pagerNumber;
        }
    }
}
