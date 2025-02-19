﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_29.Entities.Enums;
namespace Exercicio_29.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
