using System;
using System.Collections.Generic;
using System.Globalization;
namespace Exercicio_18 {
    class Program {
        static void Main(string[] args) {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i =1; i<=qtd; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int SearchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.id == SearchId);
                if(emp != null) {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine());
                    emp.IncreaseSalary(percentage);
                }
                else {
                    Console.WriteLine("Invalid ID");
                }
                Console.WriteLine();
                Console.WriteLine("Updated list of employees: ");
                foreach (Employee obj in list) {
                    Console.WriteLine(obj);
                }
            }

        }
    }

