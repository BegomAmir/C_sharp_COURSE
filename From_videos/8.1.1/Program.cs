﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\8.1.1";
            string[] files =  Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
