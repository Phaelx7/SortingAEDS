using Sorting.enums;
using Sorting.manager;
using Sorting.print;
namespace Sorting.basic_static_allocation_structures
{
    class SolutionAllocationStatic
    {
        public void LerVetor10(Sortings algoritmo)
        {
            int[] vet = ManagerFileReader.Arquivo10TXT();

            PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, algoritmo);

        }
    }
}
