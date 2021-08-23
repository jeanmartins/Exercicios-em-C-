using System;
using System.Globalization;
namespace Exercicio_3 {
    class Program {
        static void Main(string[] args) {
            /*
             * EXERCÍCIO UTILIZANDO WHILE
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine());

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo");
            */

            //Resolvendo um problema sem Orientação a Objetos
           /* string maior;
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double X = Area(a, b, c);
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double Y = Area(a,b,c);
            if(X > Y) {
                maior = "x";
            }
            else {
                maior = "Y";
            }
            Console.WriteLine($"Area de X = {X:F4}");
            Console.WriteLine("Area de X = {0}", Y.ToString("F4"));
            Console.WriteLine($"Maior área: {maior}");
            */


        }
        /*static double Area(double a, double b, double c) {
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b)*(p - c));
            return area;
        }
        */
    }
}