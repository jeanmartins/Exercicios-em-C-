using System;
using System.Globalization;
namespace Exercicio_14 {
    class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i=0; i<vect.Length; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for(int i=0; i<vect.Length; i++) {
                sum += vect[i].Price;
            }
            double avg = sum / vect.Length;
            Console.WriteLine("Preço médio = " + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
