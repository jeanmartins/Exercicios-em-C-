﻿using System;
using System.IO;

namespace Exercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error has occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
