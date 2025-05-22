using Sorting.reader;
using Sorting.utils;

namespace Sorting.manager
{
    class ManagerFileReader
    {
        static ReaderFile reader = new ReaderFile();
        public static int[] Arquivo10TXT()
        {
            ReaderFile reader = new ReaderFile("./inputs/10-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo100TXT()
        {
            ReaderFile reader = new ReaderFile("./inputs/100-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo1000TXT()
        {
            ReaderFile reader = new ReaderFile("./inputs/1000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo10000TXT()
        {
            ReaderFile reader = new ReaderFile("./inputs/10000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo100000TXT()
        {
            ReaderFile reader = new ReaderFile("./inputs/100000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo1000000TXT()
        {
            ReaderFile reader = new ReaderFile("./inputs/1000000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }
    }
}
