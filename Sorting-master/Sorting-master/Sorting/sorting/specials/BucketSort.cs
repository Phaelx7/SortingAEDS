using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorting.sorting.specials
{
    class BucketSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            int atribuicoes = 0;
            int comparacoes = 0;
            int trocas = 0;

            int n = vet.Length;
            atribuicoes++;

            if (n <= 0)
            {
                comparacoes++;
                return vet;
            }
            comparacoes++;

            int minValue = vet[0];
            int maxValue = vet[0];
            atribuicoes += 2;

            for (int i = 1; i < n; i++)
            {
                comparacoes++;
                if (vet[i] < minValue)
                {
                    minValue = vet[i];
                    atribuicoes++;
                }
                comparacoes++;
                if (vet[i] > maxValue)
                {
                    maxValue = vet[i];
                    atribuicoes++;
                }
            }

            int bucketCount = (maxValue - minValue) / n + 1;
            atribuicoes++;
            List<int>[] buckets = new List<int>[bucketCount];
            atribuicoes++;

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
                atribuicoes++;
            }
            foreach (int num in vet)
            {
                int index = (num - minValue) / n;
                buckets[index].Add(num);
                atribuicoes++;
                trocas++; //inserção no bucket considerada como troca
            }
            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i].Sort(); //.Sort é considerado caixa preta, mas vamos considerar trocas internas
                trocas += buckets[i].Count; //aproximação: cada elemento foi, no mínimo, movimentado uma vez
            }
            int k = 0;
            atribuicoes++;
            foreach (List<int> bucket in buckets)
            {
                foreach (int num in bucket)
                {
                    vet[k++] = num;
                    atribuicoes++;
                    trocas++; //reposição no vetor original
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            //Impressão das estatísticas
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas: " + trocas);

            return vet;
        }
    }
}
