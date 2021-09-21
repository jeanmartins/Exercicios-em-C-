using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_30.Entities
{
    abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPlayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
