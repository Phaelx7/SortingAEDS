namespace Sorting.utils
{
    class Conversor
    {
        public static int[] ConvertArrayStringsToInts(string[] array)
        {
            return array.Select(item => int.Parse(item)).ToArray();
        }
    }
}
