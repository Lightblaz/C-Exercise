using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Enter 2 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for(int i =0; i < num2; i++)
            {
                sum *= num1;
            }
            Console.WriteLine("The answer is " + sum);*/

            //2
            /*Console.WriteLine("Enter the Fahrenheit");
            float Ftempeture = float.Parse(Console.ReadLine());
            Console.WriteLine("Celcuis - " + convertcelcuis(Ftempeture));*/

            //3
            /*int[] arr = { 4, 5, 6, 3, 2, 5 };
            arr = reverseArray(arr);
            for(int i =0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/


            //4
            /*Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            string tempword = "";
            for(int i = word.Length-1; i > -1; i--)
            {
                tempword += word[i];
            }

            if (tempword == word)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }*/

            //5
            /*Random rnd = new Random();
            int guesses = 0;
            int randomnumber = 0 , userguess;
            randomnumber = rnd.Next(50);
            while (guesses < 7)
            {
                
                Console.WriteLine("Take a guess on the number");
                userguess = Convert.ToInt32(Console.ReadLine());
                if(userguess == randomnumber)
                {
                    Console.WriteLine("Congratulations you guessed it");
                    break;
                }
                if(userguess > randomnumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
                guesses++;
            }*/


            //6
            /*int tem = 0, val1, tot=0 ;
            Console.WriteLine("These are the armStrong numbers");
            for(int i =1; i < 500; i++)
            {
                tem = i;
                tot = 0;
                while(tem!= 0)
                {
                    val1 = tem % 10;
                    tot += (val1 * val1 * val1);
                    tem /= 10;
                }

                if(tot == i)
                {
                    Console.WriteLine(i);
                }
            }*/

            //12
            int num, max = -343424, min = 10000000;
            while (true)
            {
                Console.WriteLine("Enter zero to exit the loop");
                num = Convert.ToInt32(Console.ReadLine());
                if(num == 0)
                {
                    break;
                }

                if(num > max)
                {
                    max = num;
                }

                if(num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("The maximum number is " + max);
            Console.WriteLine("The minimum number is " + min);
        }

        static double convertcelcuis(double temp)
        {
            Console.WriteLine(5.0/9.0);
            return (temp - 32) * (5.0 / 9.0);
        }

        static int[] reverseArray(int[] arr)
        {
            int arrlength = arr.Length , count=0;
            int[] arr2 = new int[arrlength];
            for(int i = (arrlength-1); i > -1; i--)
            {
                arr2[count] = arr[i];
                count++;
            }
            return arr2;
        }
    }
}
