using System;

namespace Exercicio_16 {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(a);
            Console.WriteLine(triple);
        }
    }
}
