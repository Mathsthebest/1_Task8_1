using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/dowsr/Desktop/магистратура Новикова Е.В/1 семестр";
            if (Directory.Exists(path))
            {
               
                string[] catName = Directory.GetDirectories(path);
                foreach (string s in catName)
                {
                    Console.WriteLine("Название каталога:");
                    Console.WriteLine(s);
                    Console.WriteLine("Название файлов, входящих в каталог:");
                    string[] filesName = Directory.GetFiles(s);
                    foreach (string f in filesName)
                    {
                        Console.WriteLine(f);
                    }

                }
                
                
                
            }
            Console.ReadKey();
        }
    }
}
