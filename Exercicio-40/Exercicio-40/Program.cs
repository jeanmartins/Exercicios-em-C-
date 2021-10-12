using System;
using System.Globalization;
using Exercicio_40.Entitites;
using Exercicio_40.Services;
namespace Exercicio_40 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numberContract = int.Parse(Console.ReadLine());
            Console.Write("Date(dd / MM / yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(numberContract, date, value);

            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberInstallments);

            Console.WriteLine("Installments:");
            foreach(Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }

        }
    }
}
