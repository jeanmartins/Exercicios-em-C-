using System;
using System.Globalization;
namespace Exercicio_9 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar? ");
            double quantidadeDolares = double.Parse(Console.ReadLine());
            double resultado = ConversorDeMoeda.DolarPraReal(quantidadeDolares, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
