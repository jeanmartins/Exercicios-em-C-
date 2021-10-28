using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_51.Entities;

namespace Exercicio_51
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product
            {
                Name = "TV",
                Price = 4500.00
            });

            list.Add(new Product
            {
                Name = "Tablet",
                Price = 300.00
            });

            list.Add(new Product
            {
                Name = "Notebook",
                Price = 950.00
            });


            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

    }
}
