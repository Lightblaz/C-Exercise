using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[,] stu = { { 65, 78, 69, 55, 74 }, { 45, 85, 78, 64, 91 }, { 56, 84, 67, 58, 89 }, { 85, 65, 95, 74, 99 }, { 98, 78, 85, 84, 98 }, { 65, 45, 81, 52, 83 } };
            //1.a
            //Console.WriteLine(stu[0,0]);
            //Console.WriteLine(stu.GetLength(0)); //row-students
            //Console.WriteLine(stu.GetLength(1));//column-marks
            /*int total = 0;
            double average=0;
            for (int i = 0; i < stu.GetLength(1); i++)
            {
                total = 0;
                average = 0;
                for (int j = 0; j < stu.GetLength(0); j++)
                {
                    
                    total += stu[j, i];
                }
                average = (double)total / stu.GetLength(0);
                Console.WriteLine("Subject " + (i + 1) + " has an average of " + average);

            }*/

            //1.b
            /*int total = 0;
            double average = 0;
            for (int i = 0; i < stu.GetLength(0); i++)
            {
                total = 0;
                average = 0;
                for (int j = 0; j < stu.GetLength(1); j++)
                {

                    total += stu[i, j];
                }
                average = (double)total / stu.GetLength(1);
                Console.WriteLine("Student " + (i + 1) + " has an average of " + average);

            }*/


            //1.c
            /*int max = int.MinValue;
            for (int i = 0; i < stu.GetLength(1); i++)
            {
                max = int.MinValue;
                for (int j = 0; j < stu.GetLength(0); j++)
                {
                    if(stu[j,i] > max)
                    {
                        max = stu[j, i];
                    }
                }
                Console.WriteLine("For Subject " + (i + 1) + " the maximum number is " + max);
            }*/

            //1.d
            /*int min = int.MaxValue;
            for (int i = 0; i < stu.GetLength(1); i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < stu.GetLength(0); j++)
                {
                    if (stu[j, i] < min)
                    {
                        min = stu[j, i];
                    }
                }
                Console.WriteLine("For Subject " + (i + 1) + " the minimum mark is " + min);
            }*/

            //1.e
            /*int max = int.MinValue;
            for (int i = 0; i < stu.GetLength(0); i++)
            {
                max = int.MinValue;
                for (int j = 0; j < stu.GetLength(1); j++)
                {
                    if (stu[i, j] > max)
                    {
                        max = stu[i, j];
                    }
                }

                Console.WriteLine("For Student " + (i + 1) + " the maximum mark is " + max);

            }*/

            //1.f
            /*int min = int.MaxValue;
            for (int i = 0; i < stu.GetLength(0); i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < stu.GetLength(1); j++)
                {
                    if (stu[i, j] <min)
                    {
                        min = stu[i, j];
                    }
                }

                Console.WriteLine("For Student " + (i + 1) + " the minimum mark is " + min);

            }*/

            //2
            /*int[] arr = { 1,2,3,6,8};
            int[] arr2 = { 4,5,7,9 };
            int[] arr3 = mergesortarray(arr, arr2);
            for(int i =0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }*/

            //3
            /*int[] arr = { 3, 545, 45, 564, 7, 4, 20, 20, 260, 45, 23  , 20};
            int count20 = 0;
            bool found3 = false;
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] == 20)
                {
                    count20++;
                    if(count20 == 3)
                    {
                        found3 = true;
                        if((arr[i-1] == 20) && (arr[i-2] == 20))
                        {
                            Console.WriteLine("Three consecative 20 found");
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        break;
                    }
                }
            }
            if (!found3)
            {
                Console.WriteLine("3 20's weren't found");
            }*/

            //4
            /*Console.WriteLine((101 + 4) / 3.5);
            Console.WriteLine(true && true);
            Console.WriteLine( false && true);
            Console.WriteLine((false&&false) || (true&&true));
            Console.WriteLine((false||false) && (true&&true));*/

            //5
            /*int num = 0;
            bool same = true;
            Console.WriteLine("Enter the 4 numbes");
            num = Convert.ToInt32(Console.ReadLine());
            int target = num;
            for (int i = 0; i < 3; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if(num!= target)
                {
                    same = false;
                }
            }
            if (same)
            {
                Console.WriteLine("All numbers were same");
            }
            else
            {
                Console.WriteLine("They weren't same");
            }*/

            //6
            /*int[] arr = { 4, 0, 6, 0, 67, 0, 56 };
            int place = arr.Length - 1;
            int temp = 0;
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    if(i == place)
                    {
                        break;
                    }

                    while(arr[place] == 0)
                    {
                        place--;
                    }
                    temp = arr[i];
                    arr[i] = arr[place];
                    arr[place] = temp;
                    //place--;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }*/



            //7
            //displayOptions();

            //8
            /*int[,] table = { { 25,69,51,26 }, { 68,35,29,54 }, { 54,57,45,63 }, {61,68,47,59 } };
            int[] row = new int[4] ;
            int[] column = new int[4]; ;
            int count = 0 , total =0;
            for(int i = 0; i < table.GetLength(0); i++)
            {
                total = 0;
                for(int j =0; j < table.GetLength(1); j++)
                {
                    //Console.Write(table[i, j] + " ");
                    total += table[i, j];
                }
                row[count] = total;
                count++;
                //Console.WriteLine("");
            }
            count = 0;
            for(int i =0; i < table.GetLength(1); i++)
            {
                total = 0;
                for(int j =0; j < table.GetLength(0); j++)
                {
                    total += table[j, i];
                    //Console.Write(table[j, i] + " ");
                }
                column[count] = total;
                count++;
                //Console.WriteLine(" ");
            }
            count = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                total = 0;
                Console.Write("    ");
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine(row[count]);
                count++;
            }
            total = 0;
            for(int i =0; i  < column.Length; i++)
            {
                Console.Write(column[i] + " ");
                total += column[i];
            }
            Console.Write(total);*/

            //9
            /*int num = 0;
            Console.WriteLine("Enter a number");
            int target = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i < target; i++)
            {
                for(int j =0; j < (i+1); j++)
                {
                    num++;
                    Console.Write(num + " ");
                }
                Console.WriteLine("");
            }*/


            //10
            string d = "XY#6Z1#4023";
            int looprun = 0;
            for(int i =0; i < d.Length; i++)
            {
                //Console.Write(d[i]);

                if(d[i] == '#')
                {
                    i++;
                    looprun = int.Parse(d[i].ToString());
                    for (int j = 0; j < looprun; j++)
                    {
                        Console.Write(d[i+1]);
                    }
                    i++;
                }
                Console.Write(d[i]);
            }
        }



        static int[] mergesortarray(int[] arr, int[] arr2)
        {
            int Arrlen = arr.Length + arr2.Length;
            int[] arr3 = new int[Arrlen];
            int count1 = 0, count2 = 0, count3 = 0; ;
            while (true)
            {
                if (arr[count1] < arr2[count2])
                {
                    arr3[count3] = arr[count1];
                    count1++;
                }
                else
                {
                    arr3[count3] = arr2[count2];
                    count2++;
                }

                count3++;

                if (count1 == arr.Length)
                {
                    for (int i = count2; i < arr2.Length; i++)
                    {
                        arr3[count3] = arr[i];
                        count3++;
                    }
                    break;
                }
                else if (count2 == arr.Length)
                {
                    for (int i = count1; i < arr.Length; i++)
                    {
                        arr3[count3] = arr[i];
                        count3++;
                    }
                    break;
                }
            }

            return arr3;
        }

        static void displayOptions()
        {
            Console.WriteLine("Declare an array of 10 integers");
            Console.WriteLine("Accept elements of an array");
            Console.WriteLine("Display elements of an array");
            Console.WriteLine("Search the elements within array given by user");
            Console.WriteLine("Sort the array using bubble sort method");


        }

        static int[] declareArray()
        {
            int[] arr = new int[10];
            return arr;
        }

        static void displayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void appendArray(int[] arr, int value , int count)
        {
            arr[count] = value;
        }

        static void findElement(int[] arr, int felement)
        {
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == felement)
                {
                    Console.WriteLine("Element found at index" + i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Element not found");
            }
        }

        static int[] sortarray(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;

                    }
                }
            }
            return arr;
        }
    }
}
