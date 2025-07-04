namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static void MergeVet(int[] vet, int esq, int meio, int dir)
        {
            var esqArrayLength = meio - esq + 1;
            var dirArrayLength = dir - meio;
            var esqTempVet = new int[esqArrayLength];
            var dirTempVet = new int [dirArrayLength];
            int i, j;

            for ( i = 0; i < esqArrayLength; i++ )
            {
                esqTempVet[i] = vet[esq + 1];
            }
            for (j = 0; j < dirArrayLength; j++ )
            {
                dirTempVet[j] = vet[meio + 1 +  j];
            }

            i = 0;
            j = 0;
            int k = esq;

            while (i < esqArrayLength && j < dirArrayLength)
            {
                if (esqTempVet[i] <= dirTempVet[j])
                {
                    vet[k++] = esqTempVet[i++];
                }
                else
                {
                    vet[k++] = dirTempVet[j++];
                }
            }
            while (i < esqArrayLength)
            {
                vet[k++] = esqTempVet[i++];
            }
            while(j < dirArrayLength)
            {  
                vet[k++] = dirTempVet[j++];
            }
        }
        public static int[] Sorting(int[] vet, int esq, int dir)
        {

            if(esq < dir)
            {
                int meio = esq + (dir - esq) / 2;

                Sorting(vet, esq, meio);
                Sorting(vet, meio + 1, dir);
                MergeVet(vet, esq, meio, dir);
            }
            return vet;
        }
    }
}
