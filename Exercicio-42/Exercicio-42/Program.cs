using System;
using System.Collections.Generic;
using System.IO;
using Exercicio_42.Entities;
namespace Exercicio_42 {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\pasta\file.csv";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            }
            
            catch (IOException e) {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            
        }
    }
}
