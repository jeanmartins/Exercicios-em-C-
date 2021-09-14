using System;
using Exercicio_26.Entities;
namespace Exercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);
            //account.Balance = 200;
        }
    }
}
