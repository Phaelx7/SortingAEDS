namespace Sorting.reader
{
    class ReaderFile
    {
        public string pathFile;
        public ReaderFile()
        {
            pathFile = "";
        }
        public ReaderFile(string pathFile)
        {
            this.pathFile = pathFile;
        }

        public string LerTodoArquivo()
        {
            return File.ReadAllText(this.pathFile);
        }

        public string[] LerLinhaALinha()
        {
            int n = GetNumLinhas();
            string[] linhas = new string[n];
            int i = 0;
            foreach (var linha in File.ReadLines(this.pathFile))
            {
                linhas[i++] = linha;
            }

            return linhas;
        }

        public int GetNumLinhas()
        {
            return File.ReadLines(this.pathFile).Count();
        }
    }
}
