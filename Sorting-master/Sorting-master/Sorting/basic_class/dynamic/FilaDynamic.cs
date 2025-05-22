namespace Sorting.basic_class.dynamic
{
    class FilaDynamic
    {
        public Celula? primeiro;
        public Celula? ultimo;
        public int tamanho;
        public FilaDynamic()
        {
            this.primeiro = this.ultimo = new Celula();
            tamanho = 0;
        }
        public bool EstaVazia()
        {
            return tamanho == 0;
        }
        public int Tamanho()
        {
            return tamanho;
        }
        public bool Inserir(int item)
        {
            Celula nova = new Celula(item);

            if (EstaVazia())
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.prox = nova;
                ultimo = nova;
            }
            tamanho++;
            return true;
        }
        public int Remover()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Fila vazia");
                return -1;
            }
            Celula removida = primeiro.prox;
            int valor = removida.valor;
            primeiro.prox = removida.prox;

            if (removida == ultimo)
            {
                ultimo = primeiro; 
            }
            tamanho--;
            return valor;
        }
    }
}
