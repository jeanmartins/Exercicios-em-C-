using System;
using System.IO;
using Exercicio_59.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicio_59
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/home/jean/Documentos/in";
            List<Product> list = new List<Product>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string [] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Avarage price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}