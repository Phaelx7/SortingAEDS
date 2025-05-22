using System;
using System.Diagnostics;
namespace Sorting.sorting.simple
{
    class SelectionSort // Metodo de Ordenação por Seleção
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            int n = vet.Length;
            int min;

            int atribuicoes = 0;
            int comparacoes = 0;
            int trocas = 0;

            atribuicoes++; // n = vet.Length

            for (int i = 0; i < n; i++)
            {
                atribuicoes++; // i = 0
                comparacoes++; // i < n

                min = i;
                atribuicoes++; // min = i

                for (int j = i + 1; j < n; j++)
                {
                    atribuicoes++; // j = i + 1
                    comparacoes++; // j < n

                    comparacoes++; // vet[j] < vet[min]
                    if (vet[j] < vet[min])
                    {
                        min = j;
                        atribuicoes++; // min = j
                    }

                    atribuicoes++; // j++
                }

                if (min != i)
                {
                    int tmp = vet[i];
                    vet[i] = vet[min];
                    vet[min] = tmp;

                    atribuicoes += 3; // tmp, vet[i], vet[min]
                    trocas++;
                }

                atribuicoes++; // i++
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas: " + trocas);

            return vet;
        }
    }
}
