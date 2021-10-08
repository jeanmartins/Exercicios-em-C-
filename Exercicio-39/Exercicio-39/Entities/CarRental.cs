using System;

namespace Exercicio_39.Entities {
    class CarRental {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vechicle Vechicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vechicle vechicle) {
            Start = start;
            Finish = finish;
            Vechicle = vechicle;
            Invoice = null;
        }

    }
}
