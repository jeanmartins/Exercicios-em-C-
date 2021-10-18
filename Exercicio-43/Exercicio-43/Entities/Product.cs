using System;
using System.Globalization;

namespace Exercicio_43.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = Price;
        }

        public override string ToString()
        {
            return Name
                   + ", "
                   + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new Exception("Object isnt a product!");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
    
}