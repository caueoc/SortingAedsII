namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        static void Heapfy(int[] vet, int size, int index)
        {
            var largestIndex = index;
            var leftChild = 2 * index + 1;
            var rightChild = 2 * index + 2;

            if (leftChild < size && vet[leftChild] > vet[largestIndex])
            {
                largestIndex = leftChild;
            }
            if (rightChild < size && vet[rightChild] > vet[largestIndex])
            {
                largestIndex = rightChild;
            }
            if (largestIndex != index)
            {
                var temp = vet[index];
                vet[index] = vet[largestIndex];
                vet[largestIndex] = temp;

                Heapfy(vet, size, largestIndex);
            }
        }
        public static int[] Sorting(int[] vet)
        {
            int size = vet.Length;
            if (size <= 1) return vet;

            for (int i = size / 2 - 1; i >= 0; i--)
            {
                Heapfy(vet, size, i);
            }
            for (int j = size - 1; j >= 0; j--)
            {
                var temp = vet[0];
                vet[0] = vet[j];
                vet[j] = temp;

                Heapfy(vet, j, 0);
            }
            return vet;
        }
    }
}
