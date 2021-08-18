using System;

namespace PrimeiroExercicio {
    class Program {
        static void Main(string[] args) {
            bool completo = false;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            char genero = '\u0017';
            string nome = "Maria";
            object obj1 = "Alexandre";

            Console.WriteLine(char.MaxValue);
            Console.WriteLine(nome);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n5);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}
