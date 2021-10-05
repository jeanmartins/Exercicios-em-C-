using System;
using System.IO;
using System.Globalization;
using Exercicio_38.Entitites;
namespace Exercicio_38 {
    class Program {
        static void Main(string[] args) {
            string source = @"c:\temp\myfolder";
            string sourcePath = source + @"\products.csv";
            Directory.CreateDirectory(source + @"\out");
            string targetFilePath = source + @"\out\summary.csv";

            try {
                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    string[] lines = File.ReadAllLines(sourcePath);
                    foreach (string line in lines) {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                        double quantity = double.Parse(fields[2]);
                        Product product = new Product(name, price, quantity);
                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2",CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
