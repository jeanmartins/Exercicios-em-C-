using System;

namespace Exercicio_7 {
    class Program {
        static void Main(string[] args) {
            Retangulo rect = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            rect.Largura = double.Parse(Console.ReadLine());
            rect.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine(rect);
        }
    }
}
