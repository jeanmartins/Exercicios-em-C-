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
            double AreaX = x.Area();
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
             y.A = double.Parse(Console.ReadLine());
             y.B = double.Parse(Console.ReadLine());
             y.C = double.Parse(Console.ReadLine());
            double AreaY = y.Area();
            if (AreaX > AreaY) {
                maior = "x";
            }
            else {
                maior = "Y";
            }
            Console.WriteLine($"Area de X = {AreaX:F4}");
            Console.WriteLine("Area de X = {0}", AreaY.ToString("F4"));
            Console.WriteLine($"Maior área: {maior}");
        }
    }
}
