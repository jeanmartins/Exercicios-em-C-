using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_30.Entities;
namespace Exercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPlayer> list = new List<TaxPlayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i / c) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (ch)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        list.Add(new Individual(name, anualIncome, healthExpenditures));
                        break;
                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Company(name, anualIncome, numberOfEmployees));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPlayer taxPlayer in list)
            {
                Console.WriteLine(
                    taxPlayer.Name
                    + ": $ "
                    + taxPlayer.Tax().ToString("F2",CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}
