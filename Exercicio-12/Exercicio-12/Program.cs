using System;

namespace Exercicio_12 {
    class Program {
        static void Main(string[] args) {
            Point p;
            p.Y = 20;
            p.X = 5;
            Console.WriteLine(p);

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
