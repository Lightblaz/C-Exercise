using System;
using System.Linq;

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
            /*Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(num +" x " + i + " = " + (num*i));
            }*/

            //6
            /*int total = 0, num , count=0;
            float average = 0f;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            while(num >= 0)
            {
                total += num;
                count++;
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The total is " + total);
            Console.WriteLine("The average is " + (total/count));*/


            //7
            /*int pustotal = 0 , negtotal = 0, num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                if(num > 0)
                {
                    pustotal += num;
                }
                else
                {
                    negtotal += num;
                }
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The pos total is " + pustotal);
            Console.WriteLine("The neg total is " + negtotal);*/

            //8
            /*int[] array1 = new int[10];
            float total = 0;
            int num;
            for(int i =0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                array1[i] = num;
                total += array1[i];
            }

            Console.WriteLine("Total is " + total);
            Console.WriteLine("Average is " + (total / array1.Length));*/

            //9
            /*int[] array1 = new int[10];
            float total = 0;
            int num;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                array1[i] = num;
                total += array1[i];
            }
            int n = array1.Length , val , flag;
            for (int i = 1; i < n; i++)
            {
                val = array1[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < array1[j])
                    {
                        array1[j + 1] = array1[j];
                        j--;
                        array1[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            Console.WriteLine("\nSorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array1[i] + " ");
            }*/

            //10
            /*for(int i =0; i < 5; i++)
            {
                for(int j=0; j < 10; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }*/

            //11
            /*for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < (i+1); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }*/

            //12
            int[] array1 = { 1, 4, 2, 86, 7 };
            int[] array2 = { 7, 5, 9, 14, 0, 2, 6 }; 
            var intersect = array1.Intersect(array2);

            foreach (int value in intersect)
            {
                Console.WriteLine(value);
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
