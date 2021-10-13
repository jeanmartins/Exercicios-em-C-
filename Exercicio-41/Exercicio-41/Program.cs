using System;
using Exercicio_41.Enums;
using Exercicio_41.Models.Entities;
namespace Exercicio_41 {
    class Program {
        static void Main(string[] args) {

            IShape s1 = new Circle() {
                Radius = 2.0,
                Color = Color.White
            };
            IShape s2 = new Rectangle(){
                Width = 3.5, Height = 4.2, Color = Color.Black
            };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
    }
    }
}
