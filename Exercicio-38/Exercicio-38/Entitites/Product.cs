using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_38.Entitites {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product(string name, double price, double quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total() {
            return Price * Quantity;
        }
    }
}
