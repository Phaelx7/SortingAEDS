using System;
using System.Diagnostics;
namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int atribuicoes = 0;
        static int comparacoes = 0;
        static int copias = 0;
        public static int[] Sorting(int[] vet, int esquerda, int direita)
        {
            stopwatch.Start();
            comparacoes++; // if (esquerda < direita)
            if (esquerda < direita)
            {
                int meio = (esquerda + direita) / 2;
                atribuicoes++; // meio

                Sorting(vet, esquerda, meio);
                Sorting(vet, meio + 1, direita);
                Juncao(vet, esquerda, meio, direita);
            }
            // Imprimir estatísticas apenas na primeira chamada
            if (esquerda == 0 && direita == vet.Length - 1)
            {
                stopwatch.Stop();
                Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
                Console.WriteLine("Número de atribuições: " + atribuicoes);
                Console.WriteLine("Número de comparações: " + comparacoes);
                Console.WriteLine("Número de cópias: " + copias);
            }
            return vet;
        }
        private static void Juncao(int[] vet, int esquerda, int meio, int direita)
        {
            int n1 = meio - esquerda + 1;
            int n2 = direita - meio;
            atribuicoes += 2;

            int[] L = new int[n1];
            int[] R = new int[n2];
            atribuicoes += 2;

            Array.Copy(vet, esquerda, L, 0, n1);
            Array.Copy(vet, meio + 1, R, 0, n2);
            copias += n1 + n2;

            int i = 0, j = 0, k = esquerda;
            atribuicoes += 3;

            while (i < n1 && j < n2)
            {
                comparacoes++;
                if (L[i] <= R[j])
                {
                    vet[k++] = L[i++];
                    atribuicoes++;
                    copias++;
                }
                else
                {
                    vet[k++] = R[j++];
                    atribuicoes++;
                    copias++;
                }
            }
            while (i < n1)
            {
                comparacoes++;
                vet[k++] = L[i++];
                atribuicoes++;
                copias++;
            }
            while (j < n2)
            {
                comparacoes++;
                vet[k++] = R[j++];
                atribuicoes++;
                copias++;
            }
        }
    }
}
