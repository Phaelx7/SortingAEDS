using System;
using System.Diagnostics;
using Sorting.basic_class.dynamic;
using Sorting.basic_class.@static;
namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        static ulong atribuicoes = 0;
        static ulong comparacoes = 0;
        static ulong trocas = 0;
        static Stopwatch stopwatch = new Stopwatch();
        public static int[] Sorting(int[] vet, int inicio, int fim) //Sorting normal para vetor inteiro
        {
            stopwatch.Start();
            comparacoes++; // if (inicio < fim)
            if (inicio < fim)
            {
                int pivo = vet[fim];
                int i = inicio;
                atribuicoes += 2;
                for (int j = inicio; j < fim; j++)
                {
                    comparacoes++; // vet[j] < pivo
                    if (vet[j] < pivo)
                    {
                        (vet[i], vet[j]) = (vet[j], vet[i]);
                        trocas++;
                        i++;
                        atribuicoes++;
                    }
                }
                (vet[i], vet[fim]) = (vet[fim], vet[i]);
                trocas++;

                Sorting(vet, inicio, i - 1);
                Sorting(vet, i + 1, fim);
            }
            // Exibir apenas ao final da execução principal
            if (inicio == 0 && fim == vet.Length - 1)
            {
                stopwatch.Stop();
                Console.WriteLine("Tempo de execução: " + stopwatch + "ms");
                Console.WriteLine("Número de atribuições: " + atribuicoes);
                Console.WriteLine("Número de comparações: " + comparacoes);
                Console.WriteLine("Número de trocas: " + trocas);
            }
            return vet;
        }
        public static Lista Sorting(Lista vet, int inicio, int fim) //Sorting para Lista Estática
        {
            if (inicio < fim)
            {
                int pivo = vet.lista[fim];
                int i = inicio;
                for (int j = inicio; j < fim; j++)
                {
                    if (vet.lista[j] < pivo)
                    {
                        (vet.lista[i], vet.lista[j]) = (vet.lista[j], vet.lista[i]);
                        i++;
                    }
                }
                (vet.lista[i], vet.lista[fim]) = (vet.lista[fim], vet.lista[i]);

                Sorting(vet, inicio, i - 1);
                Sorting(vet, i + 1, fim);
            }
            return vet;
        }
        public static ListaDynamic Sorting(ListaDynamic vet, int inicio, int fim) //Sorting para Lista Dinâmica - Lista Encadeada
        {
            if (inicio < fim)
            {
                int pivo = vet.GetItem(fim).valor;
                int i = inicio;
                for (int j = inicio; j < fim; j++)
                {
                    if (vet.GetItem(j).valor < pivo)
                    {
                        (vet.GetItem(i).valor, vet.GetItem(j).valor) = (vet.GetItem(j).valor, vet.GetItem(i).valor);
                        i++;
                    }
                }
                (vet.GetItem(i).valor, vet.GetItem(fim).valor) = (vet.GetItem(fim).valor, vet.GetItem(i).valor);

                Sorting(vet, inicio, i - 1);
                Sorting(vet, i + 1, fim);
            }
            return vet;
        }
    }
}
