﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_16 {
    class Calculator {
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
        public static void Tripe(ref int x) {
            x = x * 3;
        }
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
