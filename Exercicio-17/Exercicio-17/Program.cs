using System;
using System.Collections.Generic;
namespace Exercicio_17 {
    class Program {
        static void Main(string[] args) {
            List<string> lista = new List<string> { "Jean", "Amorzito da minha vida", "Rianinha" , "Riane amor da minha vida"};


            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + lista.Count);
            
            string s2 = lista.FindLast(x => x[0] == 'J');
            Console.WriteLine(s2);
            string s1 = lista.Find(x => x[0] == 'R');
            Console.WriteLine(s1);

            int pos1 = lista.FindIndex(x => x[0] == 'R');
            Console.WriteLine("First position R: " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine("Last position R: " + pos2);

            List<string> lista2 = lista.FindAll(x => x.Length >= 5);
            foreach(string obj in lista2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            lista.Remove("Jean");
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            lista.RemoveAll(x => x[0] == 'A');
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
        }
       
    }
}
