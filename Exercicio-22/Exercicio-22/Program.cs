using System;
using Exercicio_22.Entities;
using Exercicio_22.Entities.Enums;
namespace Exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Order item = new Order
            {
                Id = 3587,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };
            Console.WriteLine(item);
            Console.WriteLine();

            string txt = OrderStatus.Processing.ToString();
            Console.WriteLine(txt);
            Console.WriteLine();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            
        }
    }
}
