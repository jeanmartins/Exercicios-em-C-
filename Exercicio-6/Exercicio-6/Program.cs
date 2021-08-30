using System;
using System.Globalization;

namespace Exercicio_6 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.0, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
