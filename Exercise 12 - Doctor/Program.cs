using System;

namespace Exercise_12___Doctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoctorRegistry dr = new DoctorRegistry("jaffna");
            Doctor d = new Doctor("jason" , "4545"  , "eyes");
            dr.register(d);
            if (!dr.register(d))
            {
                Console.WriteLine("Already on list");
            }
        }
    }
}
