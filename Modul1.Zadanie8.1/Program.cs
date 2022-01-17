using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul1.Zadanie8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"E:\!!! ОБУЧЕНИЕ 2021");
            Console.WriteLine("Название каталога: {0} ", @"E:\!!! ОБУЧЕНИЕ 2021");
            foreach (var item in directory.GetDirectories())   
            {
                Console.WriteLine("Название подкаталога: {0}", item.Name); 
                foreach (var it in item.GetDirectories())
                    Console.WriteLine("Список файлов: {0}", it.Name);  
                Console.WriteLine();
            }
            foreach (var item in directory.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}

