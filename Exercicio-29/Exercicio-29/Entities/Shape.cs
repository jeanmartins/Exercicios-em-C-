﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_29.Entities.Enums;
namespace Exercicio_29.Entities
{
     abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
