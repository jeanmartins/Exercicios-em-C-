using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_25.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return
                Product +
                "Quantity: " + Quantity + ", " +
                "Subtotal: " + subTotal();
        }
    }
}
