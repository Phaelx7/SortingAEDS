using System.Diagnostics;
namespace Sorting.sorting.efficient
{
    class ShellSort // Método de Ordenação por Inserção com intervalos
    {
       static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            int n = vet.Length; // Define o tamanho do vetor
            int h = 1;
            // Calcula o intervalo inicial usando a sequência de Knuth
            while (h < n / 3)
            {
                h = 3 * h + 1;
            }
            // Realiza o Shell Sort
            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    int x = vet[i];
                    int j = i;
                    // Realiza a inserção com base no intervalo h
                    while (j >= h && vet[j - h] > x)
                    {
                        vet[j] = vet[j - h];
                        j -= h;
                    }
                    vet[j] = x;
                }
                // Reduz o intervalo
                h /= 3;
            }
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
            return vet;
        }
    }
}
