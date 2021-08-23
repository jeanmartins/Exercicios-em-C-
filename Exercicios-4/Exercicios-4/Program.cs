using System;

namespace Exercicios_4 {
    class Program {
        static void Main(string[] args) {
            string maior;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
             x.A = double.Parse(Console.ReadLine());
             x.B = double.Parse(Console.ReadLine());
             x.C = double.Parse(Console.ReadLine());
            double X = Area(x.A, x.B, x.C);
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
             y.A = double.Parse(Console.ReadLine());
             y.B = double.Parse(Console.ReadLine());
             y.C = double.Parse(Console.ReadLine());
            double Y = Area(y.A, y.B, y.C);
            if (X > Y) {
                maior = "x";
            }
            else {
                maior = "Y";
            }
            Console.WriteLine($"Area de X = {X:F4}");
            Console.WriteLine("Area de X = {0}", Y.ToString("F4"));
            Console.WriteLine($"Maior área: {maior}");
        }
        static double Area(double a, double b, double c) {
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
