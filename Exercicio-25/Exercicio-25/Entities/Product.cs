using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_25.Entities
{
    class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return
                Name + ", " +
                "$" + Price.ToString("F2") +", ";

        }
    }
}
