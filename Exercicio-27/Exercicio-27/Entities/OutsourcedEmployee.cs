using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_27.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double addtionalCharge) : base(name,hours,valuePerHour)
        {
            AdditionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }
    }
}
