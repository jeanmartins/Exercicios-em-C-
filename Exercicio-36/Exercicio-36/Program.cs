﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio_36 {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\myfolder";

            try {
                
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders) {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newFolder");

            }
            catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }



        }
    }
}
