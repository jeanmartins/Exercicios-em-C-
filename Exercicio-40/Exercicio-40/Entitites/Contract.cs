﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_40.Entitites {
    class Contract {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void addInstallment(Installment installment) {
            Installments.Add(installment);
        }
    }
}
