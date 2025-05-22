namespace Sorting.utils
{
    class UtilClonar
    {
        public static int[] Clonar(int[] vet)
        {
            int[] clone = new int[vet.Length];

            for (int i = 0; i < vet.Length; i++)
            {
                clone[i] = vet[i];
            }

            return clone;
        }
    }
}
