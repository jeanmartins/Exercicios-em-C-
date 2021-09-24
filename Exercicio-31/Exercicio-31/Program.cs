using System;
using System.Globalization;
using Exercicio_31.Entities;
using Exercicio_31.Entities.Exceptions;
namespace Exercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Account acc1 = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            try
            {
                acc1.Withdraw(amount);
                Console.WriteLine("New balance: " + acc1.Balance);
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
           

        }
    }
}
