using System;
using System.Diagnostics;

namespace Sorting.sorting.simple
{
    class BubbleSort // Metodo da Bolha
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();

            int n = vet.Length;

            ulong atribuicoes = 0;
            ulong comparacoes = 0;
            ulong trocas = 0;

            atribuicoes++; // n = vet.Length

            for (int i = 0; i < n; i++)
            { 
                atribuicoes++; // i = 0
                comparacoes++; // i < n

                for (int j = n - 1; j > i; j--)
                {
                    atribuicoes++; // j = n - 1
                    comparacoes++; // j > i

                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;

                        atribuicoes += 3; // tmp, vet[j], vet[j - 1]
                        trocas++;
                    }
                     comparacoes++; // vet[j] < vet[j - 1]

                    atribuicoes++; // j-- (no final do laço interno)
                }

                atribuicoes++; // i++ (no final do laço externo)
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            // Impressão dos contadores
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas: " + trocas);

            return vet;
        }
    }
}
