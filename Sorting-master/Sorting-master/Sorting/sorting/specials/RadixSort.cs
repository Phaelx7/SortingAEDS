using System;
using System.Diagnostics;

namespace Sorting.sorting.specials
{
    class RadixSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] arr)
        {
            stopwatch.Start();
            int atribuicoes = 0;
            int comparacoes = 0;
            int trocas = 0;

            int max = GetMax(arr, ref atribuicoes, ref comparacoes);

            //Aplicar CountingSort para cada dígito (unidade, dezena, centena, ...)
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                arr = CountingSortByDigit(arr, exp, ref atribuicoes, ref comparacoes, ref trocas);
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            //Impressão das estatísticas
            Console.WriteLine("Número de atribuições: " + atribuicoes);
            Console.WriteLine("Número de comparações: " + comparacoes);
            Console.WriteLine("Número de trocas: " + trocas);

            return arr;
        }
        private static int GetMax(int[] arr, ref int atribuicoes, ref int comparacoes)
        {
            int max = arr[0];
            atribuicoes++;
            foreach (var num in arr)
            {
                comparacoes++;
                if (num > max)
                {
                    max = num;
                    atribuicoes++;
                }
            }
            return max;
        }
        private static int[] CountingSortByDigit(int[] arr, int exp, ref int atribuicoes, ref int comparacoes, ref int trocas)
        {
            int[] output = new int[arr.Length];
            int[] count = new int[10]; //Dígitos de 0 a 9
            atribuicoes += 2;

            //Contar a ocorrência de cada dígito no expoente atual
            foreach (var num in arr)
            {
                int digit = (num / exp) % 10;
                count[digit]++;
                atribuicoes++;
            }
            //Atualizar o array de contagem
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
                atribuicoes++;
            }
            //Construir o array de saída (ordenação estável)
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
                atribuicoes += 2;
                trocas++;
            }
            return output;
        }
    }
}