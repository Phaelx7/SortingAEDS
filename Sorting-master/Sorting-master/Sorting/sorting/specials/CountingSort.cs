using System;
using System.Diagnostics;

namespace Sorting.sorting.specials
{
    class CountingSort //Método de Ordenação por Contagem
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] arr, int max)
        {
            stopwatch.Start();
            ulong atribuicoes = 0;
            ulong comparacoes = 0;
            ulong trocas = 0;

            int[] count = new int[max + 1];
            int[] output = new int[arr.Length];
            atribuicoes += 2;

            //Contar a ocorrência de cada número
            foreach (var num in arr)
            {
                count[num]++;
                atribuicoes++;
            }
            //Alterar o array de contagem para posições finais
            for (int i = 1; i <= max; i++)
            {
                comparacoes++;
                count[i] += count[i - 1];
                atribuicoes++;
            }
            //Construir o array de saída (fazemos de trás para frente para manter estabilidade)
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                comparacoes++;
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
                atribuicoes += 2;
                trocas++;
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            //Impressão das estatísticas
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas: " + trocas);

            return output;
        }
    }
}
