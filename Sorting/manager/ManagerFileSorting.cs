using Sorting.enums;
using Sorting.print;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado = [];

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
                    ordenado = MergeSort.Sorting(vet, 0, vet.Length - 1);
                    break;

                case Sortings.HEAPSORT:
                    ordenado = HeapSort.Sorting(vet);
                    break;
            }
            PrintSolutionStatic.ImprimirArrayQuebraLinha(ordenado);
        }
    }
}
