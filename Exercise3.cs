using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            displayoptions();
        }

        static void displayoptions()
        {
            //1
            /*Console.WriteLine("1: +");
            Console.WriteLine("2: -");
            Console.WriteLine("3: *");
            Console.WriteLine("4: /");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float total = 0f;
            switch (choice)
            {
                case 1:
                    total = add(num1, num2);
                    break;
                case 2:
                    total = minus(num1, num2);
                    break;
                case 3:
                    total = mul(num1, num2);
                    break;
                case 4:
                    total = divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Enter number between 1 and 4");
                    break;
            }

            Console.WriteLine("The total is " + total);*/

            //2
            /*int total = 0;
            for(int i =0; i < 11; i++)
            {
                total += i;
            }
            Console.WriteLine("The total is " + total);*/

            //3
            /*for(int i =0; i < 101; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //4
            /*Console.WriteLine("Enter a range");
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for(int i = start; i < end; i++)
            {
                if( i%2 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine("The total is " + total);*/


            //5
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(num +" x " + i + " = " + (num*i));
            }
        }
        static float add(float num1, float num2)
        {
            return num1 + num2;
        }
        static float minus(float num1, float num2)
        {
            return num1 - num2;
        }
        static float mul(float num1, float num2)
        {
            return num1 * num2;
        }
        static float divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
