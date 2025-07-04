using Sorting.basic_class.@static;
using Sorting.basic_static_allocation_structures;
using Sorting.manager;
using Sorting.print;
using Sorting.reader;
using Sorting.sorting.simple;
using Sorting.utils;
using Sorting.enums;

public class Program
{
    public static void Main(string[] args)
    {
        

        int[] listaNums = [];
        Sortings alg = Sortings.BUBBLESORT;
        Console.WriteLine("Escolha qual arquivo será lido:\n1: 10-aleatórios\n2: 100-aleatórios\n3: 1000-aleatórios" +
            "\n4: 10000-aleatórios\n5: 10000-aleatórios\n6: 100000-aleatórios\n7: 1000000-aleatórios ");
        int escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                listaNums = ManagerFileReader.Arquivo10TXT();
                break;
            case 2:
                listaNums= ManagerFileReader.Arquivo100TXT();
                break;
            case 3:
                listaNums = ManagerFileReader.Arquivo1000TXT();
                break;
            case 4:
                listaNums = ManagerFileReader.Arquivo10000TXT();
                break;
            case 5:
                listaNums = ManagerFileReader.Arquivo100000TXT();
                break;
            case 6:
                listaNums = ManagerFileReader.Arquivo1000000TXT();
                break;
            case 7:
                listaNums = ManagerFileReader.Arquivo1000000TXT();
                break;
        }
        Console.WriteLine("Escolha o tipo de ordenação:\n1: bubble\n2: insertion\n3: selection\n4: heap\n5: Merge");
        escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                alg = Sortings.BUBBLESORT;
                break;
            case 2:
                alg = Sortings.INSERTIONSORT;
                break;
            case 3:
                alg = Sortings.SELECTIONSORT;
                break;
            case 4:
                alg = Sortings.HEAPSORT;
                break;
            case 5:
                alg = Sortings.MERGESORT;
                break;

        }
        ManagerFileSorting.Ordenar(alg, listaNums);
            //PrintSolutionStatic.ImprimirArrayQuebraLinha(ManagerFileSorting.Ordenar(alg, listaNums));

    }
}