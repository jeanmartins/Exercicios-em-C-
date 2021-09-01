using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_11 {
    class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular) {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial): this(numeroConta, nomeTitular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= (quantia + 5);
        }

        public override string ToString() {
            return "Conta: " + NumeroConta + ", " + "Titular: " + NomeTitular + ", " + "Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
