using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_41.Enums;
namespace Exercicio_41.Models.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
