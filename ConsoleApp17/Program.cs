using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dir0 = new List<string>();
            List<string> List_dir3 = new List<string>();
            List<string> List_dir4 = new List<string>();
            string path_name = Console.ReadLine();

            IEnumerable<string> dir1 = Directory.EnumerateDirectories("C:\\Users\\Studen 2\\source\\repos");
            IEnumerable<string> dir2;
            int z = 0;
            while (z < 1000)
            {
                foreach (string dirName in dir1)
                {
                    List_dir3.Clear();
                    dir2 = Directory.EnumerateDirectories(dirName);
                    dir0.Add(dirName);
                    if (dir2.Any())
                        foreach (string dirName2 in dir2)
                        {

                            List_dir3.Add(dirName2);
                        }
                    foreach (string dirName3 in List_dir3)
                        dir0.Add($"\t\t{dirName3}");
                    foreach (string dirName4 in List_dir3)
                        List_dir4.Add(dirName4);


                }

                dir1 = Directory.EnumerateDirectories(List_dir4[z]);
                z++;
            }
            bool t = false;
            foreach (string dirNm in dir0)
            {
                string[] name_dir= dirNm.Split('\\');
                
                foreach (string name in name_dir)
                {
                    if (name==path_name)
                        t=true;
                }
                if (t == true)
                {
                    //Если папка имя которой ввел пользователь существует, вывести полный путь
                    Console.WriteLine(dirNm);
                    break;
                }
            }

        }
    }
}

