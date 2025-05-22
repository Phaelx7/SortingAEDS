using Sorting.enums;
using Sorting.utils;

namespace Sorting.print
{
    static class PrintSolutionStatic
    {
        public static void ImprimirArrayMesmaLinha(int[] array, Sortings algoritmo)
        {
            Console.WriteLine("ALGORITMO - " + UtilEnum.GetDescription(algoritmo) + "\n");

            Console.WriteLine("INICIO - Imprimindo estrutura em alocação estática sem pular linha.\n");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine("\nFIM - Imprimindo estrutura em alocação estática sem pular linha.\n");
        }

        public static void ImprimirArrayQuebraLinha(int[] array)
        {
            Console.WriteLine("INICIO - Imprimindo estrutura em alocação estática com quebra de linha. \n");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nFIM - Imprimindo estrutura em alocação estática com quebra de linha.");
        }
    }
}
