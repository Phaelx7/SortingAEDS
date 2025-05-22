using Sorting.enums;
using Sorting.sorting.simple;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado;

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    ordenado = BubbleSort.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    ordenado = SelectionSort.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    ordenado = InsertionSort.Sorting(vet);
                    break;

                case Sortings.BUCKETSORT:
                    break;

                case Sortings.COUNTINGSORT:
                    break;

                case Sortings.RADIXSORT:
                    break;

                case Sortings.SHELLSORT:
                    break;

                case Sortings.QUICKSORT:
                    break;

                case Sortings.MERGESORT:
                    break;

                case Sortings.HEAPSORT:
                    break;
            }
        }
    }
}
