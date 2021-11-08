using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Exercicio_60.Entities;

namespace Exercicio_60
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/home/jean/Documentos/in";
            List<Employee> list = new List<Employee>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Enter salary: ");
            double salaryT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var emails = list.Where(p => p.Salary > salaryT).OrderBy(p => p.Name).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than " +
                              salaryT.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var avg = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).DefaultIfEmpty().Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " +
                              avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}