using System;
using System.Globalization;

namespace Exercicio_2 {
   
    
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;

            Console.WriteLine($"A soma dos números é igual a {soma}");
        }
    }
}