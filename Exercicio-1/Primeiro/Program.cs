using System;
using System.Globalization;
namespace PrimeiroExercicio {
    class Program {
        static void Main(string[] args) {
            int idade2 = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome,idade2, saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine($"{nome} tem {idade2} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine(nome + " tem " + idade2 + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            //Exercicio de Fixação

            string produto1 = "Computador";
            string produto2 = "Mesa Digitalizadora";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.23567;
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais:" + medida.ToString("F8"));
            Console.WriteLine($"Arrendodado ( três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal Invariant Culture: {0}", medida.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}
