using System;
namespace Exercicio_49
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 10, 29, 18,00,00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}