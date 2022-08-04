using System;
using System.IO;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare
            runMenu();
            Console.WriteLine(" Thank you for testing this application.");
        }

        static void runMenu()
        {
            //declare
            int choice = 0;
            int[,] stumarks = new int[10,100];
            string progressData = "";
            string yesNo;
            stumarks[0,0] = 0;

            do
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("    The Progress Statistics Generator    ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" [1] End Testing the program");
                Console.WriteLine(" [2] Display \"About\" Information");
                Console.WriteLine(" [3] Read and store data from files");
                Console.WriteLine(" [4] Generate a Results Data Table");
                Console.WriteLine(" [5] Save Results Statistics to a file");
                Console.WriteLine(" [6] Display Results Statistics from a file");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write(" Which option would you like (1-6): ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 2)
                {
                    displayText();
                }
                else if (choice == 3)
                {
                    //createLists("Results.txt");
                    stumarks = createLists("Results.txt");
                }
                else if (choice == 4 || (choice == 5))
                {
                    if (stumarks[0, 0] == 0)
                    {
                        Console.WriteLine("Please select option[3] to first load data!");
                    }
                    else
                    {
                        progressData = generateTable(stumarks);
                        if(choice == 5)
                        {
                            Console.WriteLine("Do you want to save this data? (y/n)");
                            yesNo = Console.ReadLine();
                            if (yesNo == "y")
                            {
                                saveData(progressData);
                            }
                        }

                    }
                }
                else if(choice == 6)
                {
                    DisplayTextFile(progressData);
                }
                



            } while (choice != 1);
        }

        static void displayText()
        {
            Console.WriteLine("\n \n");
            var fileStream = new FileStream(@"C:\Users\user\Downloads\Text Files\About.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // process the line
                }
                Console.ReadKey();
                Console.WriteLine("\n \n");
            }
        }


        static int[,] createLists(string filename)
        {
            int[,] stumarks = new int[10, 100];
            var fileStream = new FileStream(@"C:\Users\user\Downloads\Text Files\"+ filename, FileMode.Open, FileAccess.Read);
            int num = 0 , count1 =0  , count2 = 0;
            string temp = "";
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Console.WriteLine(line.Length);
                    temp = "";
                    for(int i =0; i < line.Length; i++)
                    {
                        if(line[i] != '\t')
                        {
                            temp += line[i];
                        }
                        else
                        {
                            //Console.WriteLine(temp);
                            num = Convert.ToInt32(temp);
                            stumarks[count1, count2] = num;
                            count1++;
                            temp = "";
                        }
                    }
                    //Console.WriteLine(temp);
                    num = Convert.ToInt32(temp);
                    stumarks[count1, count2] = num;
                    count1 = 0;
                    count2++;
                    //Console.ReadKey();
                    
                    // process the line
                }
                Console.WriteLine("     Data loading from Results.txt");
                Console.WriteLine("\n \n");
                return stumarks;
            }
        }

        /*static void CreateLists(string fileName)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\user\Downloads\Text Files\" + fileName);

            int i = 0;
            int j = 0;
            int[,] result = new int[10, 100];

            foreach (string row in text.Split('\n'))
            {
                j = 0;
                
                foreach (string col in row.Trim().Split('\t'))
                {
                    result[j, i] = int.Parse(col.Trim());
                    Console.WriteLine(result[j, i] + " " + i + " " + j);
                    j++;
                }
                if (i == 99)
                {
                    break;
                }
                i++;
                
            }


        }*/

        static string generateTable(int[,] stumarks)
        {

            Console.WriteLine("\n \n");
            //declare
            Random rnd = new Random();
            int column = rnd.Next(10);
            int nostudents = 0;
            string text = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
            string hd = "  HD: ";
            string D = "  D : ";
            string CR = "  CR: ";
            string P = "  P : ";
            string F = "  F : ";

            Console.Write("How many students in class? (1-100): ");
            nostudents = Convert.ToInt32(Console.ReadLine());
            while(nostudents <=0 && nostudents >=100)
            {
                Console.WriteLine("Value out of bounds , enter value between 1 and 100");
                nostudents = Convert.ToInt32(Console.ReadLine());
            }

            text += "You have entered " + nostudents + " Students.\n";
            Console.WriteLine("Assessment "+ column + " has been selected randomly");
            text += "Assessment " + column + " has been selected randomly\n";
            text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";

            for (int i =0; i < nostudents; i++)
            {
                if (stumarks[column, i] > 85)
                {
                    hd += "*";
                }
                else if (stumarks[column, i] > 70)
                {
                    D += "*";
                }
                else if (stumarks[column, i] > 60)
                {
                    CR += "*";
                }
                else if (stumarks[column, i] > 40)
                {
                    P += "*";
                }
                else
                {
                    F += "*";
                }
                //Console.WriteLine(stumarks[column , i]);
            }


            text += hd + "\n" + D + "\n" + CR + "\n" + P + "\n" + F + "\n \n";
            Console.WriteLine(text);
            return text;
        }

        static void saveData(string txtgraph)
        {
              
            string folder = @"C:\Users\user\Downloads\Text Files\";
            string fileName = "savedProgressData.txt";
            string fullPath = folder + fileName;
            //File.WriteAllText(fullPath, txtgraph);
            txtgraph += "\n";
            File.AppendAllText(fullPath, txtgraph);
            string readText = File.ReadAllText(fullPath);
        }

        static void DisplayTextFile(string progressData)
        {
           // Console.WriteLine("\n \n");
           // Console.WriteLine(progressData);

            Console.WriteLine("\n \n");
            var fileStream = new FileStream(@"C:\Users\user\Downloads\Text Files\savedProgressData.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // process the line
                }
                Console.ReadKey();
                Console.WriteLine("\n \n");
            }
        }
    }
}
