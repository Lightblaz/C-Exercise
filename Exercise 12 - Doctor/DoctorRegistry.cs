using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Exercise_12___Doctor
{
    class DoctorRegistry
    {
        private string province;
        private ArrayList doctors = new ArrayList();

        public DoctorRegistry(string province)
        {
            this.province = province;
        }

        public bool register(Doctor doctor)
        {
            for(int i =0; i < doctors.Count; i++)
            {
                if(doctors[i] == doctor)
                {
                    return false;
                }
            }
            doctors.Add(doctor);
            return true;
        }

        public bool deRegister(string registernumber)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (((Doctor)doctors[i]).GetRegistryNumber() == registernumber )
                {
                    doctors.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public ArrayList getDoctorList()
        {
            return doctors;
        }
    }
}
