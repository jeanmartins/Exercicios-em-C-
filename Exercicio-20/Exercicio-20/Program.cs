﻿using System;

namespace Exercicio_20 {
    class Program {
        static void Main(string[] args) {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[M, N];

            for(int i=0; i<M; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for(int j=0; j<N; j++) {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if(matriz[i,j] == x) {
                        Console.WriteLine($"Position {i},{j}");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < N - 1) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < M - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
