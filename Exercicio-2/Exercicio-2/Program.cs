using System;
using System.Globalization;

namespace Exercicio_2 {
   
    
    class Program {
        static void Main (string[] args) {
            //Exercicio 01
            int n = 0;
            while (n != 1) {
                Console.WriteLine("Digite o número: ");
                int n1 = int.Parse(Console.ReadLine());
                int resultado = n1 % 2;
                if (resultado == 0) {
                    Console.WriteLine("PAR");
                }
                else Console.WriteLine("IMPAR");
            }
            //Exercicio 02

            string[] vetorPeca = Console.ReadLine().Split(' ');
            int codigoPeca = int.Parse(vetorPeca[0]);
            int numeroPeca = int.Parse(vetorPeca[1]);
            float valorPeca = float.Parse(vetorPeca[2],CultureInfo.InvariantCulture);


            vetorPeca = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vetorPeca[0]);
            int numeroPeca2 = int.Parse(vetorPeca[1]);
            float valorPeca2 = float.Parse(vetorPeca[2], CultureInfo.InvariantCulture);

            float totalPagar = (valorPeca * numeroPeca)+(valorPeca2 * numeroPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ {0}", totalPagar.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}