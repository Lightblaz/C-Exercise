using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            /*Console.WriteLine("Hello World!");*/


            //2
            /*Console.WriteLine("Hello");
            Console.WriteLine("Programming");*/

            //3
            /*Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);*/

            //4
            /*Console.WriteLine("Enter 2 numbes");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The addition is " + (num1+num2));*/

            //5
            /*Console.WriteLine("Enter the salesman number");
            int salesnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salesman Name");
            String SalesManName = Console.ReadLine();
            Console.WriteLine("Enter the number of units sold");
            int unitssold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit price");
            float unitprice = float.Parse(Console.ReadLine());
            Console.WriteLine("The salesman number - " + salesnumber);
            Console.WriteLine("The salesman name - " + SalesManName);
            float salesvalue = unitssold * unitprice;
            Console.WriteLine("The SalesValue - " + salesvalue);*/


            //7
            /*Console.WriteLine("Enter the student number");
            int studentnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student Name");
            String studentname = Console.ReadLine();
            Console.WriteLine("Enter the student Makrs");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            int mark2 = Convert.ToInt32(Console.ReadLine());
            int mark3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Number - " + studentnum);
            Console.WriteLine("Student Name - " + studentname);
            int total = mark1 + mark2 + mark3;
            Console.WriteLine("Total marks - " + total);
            float averagemarks = total / 3;
            Console.WriteLine("Average marks - " + averagemarks);*/

            //8
            /*if(averagemarks > 5)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }*/

            //9
            /*if(averagemarks >= 80)
            {
                Console.WriteLine("Distinction");
            }else if(averagemarks >= 70)
            {
                Console.WriteLine("Very Good pass");
            }else if(averagemarks >= 60)
            {
                Console.WriteLine("Credit");
            }else if(averagemarks >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }*/

            //10
            /*Console.WriteLine("Enter the basic salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            double commission = 0;
            if (salesvalue > 50000)
            {
                commission = (salesvalue * 0.1);
            }
            if(salary > 25000)
            {
                Console.WriteLine("Final salary - " + (salary + commission));
                Console.WriteLine("Commission - " + commission);
            }*/

            //11 circle
            //const float pi = 3.142f;
            /*Console.WriteLine("Enter the raduis to calculate the circumference and area");
            float raduis = float.Parse(Console.ReadLine());
            Console.WriteLine("Circumference - " + (2 * pi * raduis ));
            Console.WriteLine("Area - " + (pi * raduis));*/

            //12 rectangle
            /*Console.Write("Enter the Height : ");
            float Height = float.Parse(Console.ReadLine());
            Console.Write("Enter the Width : ");
            float Width = float.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter - " + 2 *(Height + Width));
            Console.WriteLine("Area - " + (Height * Width));*/

            //13 cylinder
            /*Console.Write("Enter the Raduis : ");
            float craduis = float.Parse(Console.ReadLine());
            Console.Write("Enter the Height : ");
            float Cheight = float.Parse(Console.ReadLine());
            Console.WriteLine("Surface Area - " + (2 * pi * craduis + Cheight));
            Console.WriteLine("Volume - " + (pi * (craduis * craduis) * Cheight));*/

            
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1: The area and the circumference of the circle");
            Console.WriteLine("2: The perimeter and the area of the rectangle");
            Console.WriteLine("3: The surface area and the volume of the cylinder");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    circle();
                    break;
                case 2:
                    rectangle();
                    break;
                case 3:
                    cylinder();
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 and 3");
                    break;
            }
        }

        static void circle()
        {
            const float pi = 3.142f;
            Console.WriteLine("Enter the raduis to calculate the circumference and area");
            float raduis = float.Parse(Console.ReadLine());
            Console.WriteLine("Circumference - " + (2 * pi * raduis ));
            Console.WriteLine("Area - " + (pi * raduis));
        }
        static void rectangle()
        {
            Console.Write("Enter the Height : ");
            float Height = float.Parse(Console.ReadLine());
            Console.Write("Enter the Width : ");
            float Width = float.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter - " + 2 *(Height + Width));
            Console.WriteLine("Area - " + (Height * Width));
        }
        static void cylinder()
        {
            const float pi = 3.142f;
            Console.Write("Enter the Raduis : ");
            float craduis = float.Parse(Console.ReadLine());
            Console.Write("Enter the Height : ");
            float Cheight = float.Parse(Console.ReadLine());
            Console.WriteLine("Surface Area - " + (2 * pi * craduis + Cheight));
            Console.WriteLine("Volume - " + (pi * (craduis * craduis) * Cheight));
        }
    }
}
