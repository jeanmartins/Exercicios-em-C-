using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_9 {
    class ConversorDeMoeda {
        public static double Iof = 6.0 / 100;

        public static double DolarPraReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * Iof;
        }
    }
}
