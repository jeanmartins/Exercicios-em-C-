using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_25.Entities.Enums;

namespace Exercicio_25.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem OrderItem)
        {
            OrderItems.Add(OrderItem);
        }
        public void RemoveItem(OrderItem OrderItem)
        {
            OrderItems.Remove(OrderItem);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.subTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + "$" + Total());
            return sb.ToString();
        }
    }
}
