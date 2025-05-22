using System;
using System.Diagnostics;

namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static ulong atribuicoes = 0;
        static ulong comparacoes = 0;
        static ulong trocas = 0;
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            int n = vet.Length;
            atribuicoes++; // n = vet.Length
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                atribuicoes++; // i inicial
                comparacoes++; // i >= 0
                Heapify(vet, n, i);
                atribuicoes++; // i-- no final do loop
            }
            for (int i = n - 1; i > 0; i--)
            {
                atribuicoes++; // i inicial
                comparacoes++; // i > 0
                // Troca a raiz com o último elemento
                (vet[0], vet[i]) = (vet[i], vet[0]);
                atribuicoes += 3; // troca entre vet[0] e vet[i]
                trocas++;

                Heapify(vet, i, 0);
                atribuicoes++; // i-- no final do loop
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas: " + trocas);

            return vet;
        }
        private static void Heapify(int[] vet, int n, int i)
        {
            int maior = i;
            int esquerda = 2 * i + 1;
            int direita = 2 * i + 2;

            atribuicoes += 3; // maior, esquerda, direita
            comparacoes++; // esquerda < n
            if (esquerda < n)
            {
                comparacoes++; // vet[esquerda] > vet[maior]
                if (vet[esquerda] > vet[maior])
                {
                    maior = esquerda;
                    atribuicoes++;
                }
            }
            comparacoes++; // direita < n
            if (direita < n)
            {
                comparacoes++; // vet[direita] > vet[maior]
                if (vet[direita] > vet[maior])
                {
                    maior = direita;
                    atribuicoes++;
                }
            }
            comparacoes++; // maior != i
            if (maior != i)
            {
                (vet[i], vet[maior]) = (vet[maior], vet[i]);
                atribuicoes += 3;
                trocas++;

                Heapify(vet, n, maior);
            }
        }
    }
}
