using System;
using System.IO;

namespace File_History
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Pivot85/Documents/history/";
            

            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Enter Your Name");
                string userName = Console.ReadLine();
                Console.WriteLine("select what you want");
                Console.WriteLine("1. Create File\n2. Edit File\n3. Delete File");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)

                    {
                        case 1:
                            Console.WriteLine("Enter The File Name");
                            string fileName = Console.ReadLine();
                            if (!File.Exists(path + fileName + ".txt"))
                            {
                                var myFile = File.Create(path + fileName + ".txt");
                                myFile.Close();
                                File.AppendAllText(path + "history.txt", userName + "  Created" + "  " + fileName + ".txt  at " + DateTime.Now + "\n");
                            }
                            else
                            {
                                Console.WriteLine("File Exist");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter The Name of the File");
                            fileName = Console.ReadLine();
                            if (File.Exists(path + fileName + ".txt"))
                            {
                                Console.WriteLine("Write what you want");
                                string content = Console.ReadLine();
                                File.WriteAllText(path + fileName + ".txt", content);
                                File.AppendAllText(path + "history.txt", userName + "  Modified" + "  " + fileName + ".txt  at " + DateTime.Now + "\n");
                            }
                            else
                            {
                                Console.WriteLine("File Not Exist");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter The Name of the File");
                            fileName = Console.ReadLine();
                            if (File.Exists(path + fileName + ".txt"))
                            {
                                File.Delete(path + fileName + ".txt");
                                File.AppendAllText(path + "history.txt", userName + "  Deleted" + "  " + fileName + ".txt  at " + DateTime.Now + "\n"); Console.WriteLine("File Deleted");
                            }
                            else
                            {
                                Console.WriteLine("File Not Exist");
                            }
                            break;
                        default:
                            Console.WriteLine("enter the right choice");
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); Console.WriteLine("Please select one of the options above"); }

                try
                {
                here:
                    Console.WriteLine("press ( 0 ) to start again || press ( 1 ) to Exit");
                    
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i != 0 && i != 1)
                    {
                        goto here;
                    }

                }
                catch (Exception e) { Console.WriteLine(e.Message); }

            }






        }
    }
}
