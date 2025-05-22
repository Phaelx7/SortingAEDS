using System;
using System.Diagnostics;

namespace Sorting.sorting.simple
{
    class InsertionSort // Metodo de Ordenação por Inserção
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            int j, x;
            int n = vet.Length;

            int atribuicoes = 0;
            int comparacoes = 0;
            int trocas = 0;

            atribuicoes++; // n = vet.Length

            for (int i = 1; i < n; i++)
            {
                atribuicoes++; // i = 1
                comparacoes++; // i < n

                x = vet[i];
                j = i - 1;

                atribuicoes += 2; // x = vet[i], j = i - 1

                while (j >= 0 && vet[j] > x)
                {
                    comparacoes += 2; // j >= 0 && vet[j] > x

                    vet[j + 1] = vet[j];
                    j--;

                    atribuicoes += 2; // vet[j+1], j--
                    trocas++; // movimentação = troca
                }

                comparacoes++; // condição falsa do while (última verificação)
                vet[j + 1] = x;
                atribuicoes++; // vet[j+1] = x
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas (movimentações): " + trocas);

            return vet;
        }
    }
}
