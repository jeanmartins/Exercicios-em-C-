using System;
using System.Globalization;
using Exercicio_39.Entities;
namespace Exercicio_39 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup(dd / MM / yyyy hh: mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return(dd / MM / yyyy hh: mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            CarRental carRental = new CarRental(start,finish, new Vechicle(model));


            Console.Write("Enter price per hour: ");
            
            Console.Write("REnter price per day: ");
            Console.WriteLine("INVOICE: ");

        }
    }
}
