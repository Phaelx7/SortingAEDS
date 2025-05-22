namespace Sorting.basic_class.dynamic
{
    class ListaDuplamenteEncadeada
    {
        private Celula? primeiro;
        private Celula? ultimo;
        private int tamanho;

        public ListaDuplamenteEncadeada()
        {
            primeiro = null;
            ultimo = null;
            tamanho = 0;
        }
        public int Tamanho()
        {
            return tamanho;
        }
        public bool InserirInicio(int item)
        {
            Celula nova = new Celula(item);

            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                nova.prox = primeiro;
                primeiro.ante = nova;
                primeiro = nova;
            }

            tamanho++;
            return true;
        }
        public bool InserirFim(int item)
        {
            Celula nova = new Celula(item);

            if (ultimo == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.prox = nova;
                nova.ante = ultimo;
                ultimo = nova;
            }

            tamanho++;
            return true;
        }
        public bool InserirPosicao(int pos, int item)
        {
            if (pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição inválida.");
                return false;
            }

            if (pos == 0)
            {
                return InserirInicio(item);
            }
            if (pos == tamanho)
            {
                return InserirFim(item);
            }
            Celula nova = new Celula(item);
            Celula atual = primeiro;

            for (int i = 0; i < pos - 1; i++)
            {
                atual = atual.prox;
            }
            nova.prox = atual.prox;
            nova.ante = atual;

            atual.prox.ante = nova;
            atual.prox = nova;

            tamanho++;
            return true;
        }
        public int RemoverInicio()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Lista vazia.");
                return -1;
            }
            int valor = primeiro.valor;
            primeiro = primeiro.prox;

            if (primeiro != null)
            {
                primeiro.ante = null;

            }
            else
            {
                ultimo = null;
            }
            tamanho--;
            return valor;
        }
        public int RemoverFim()
        {
            if (ultimo == null)
            {
                Console.WriteLine("Lista vazia.");
                return -1;
            }
            int valor = ultimo.valor;
            ultimo = ultimo.ante;

            if (ultimo != null)
            {
                ultimo.prox = null;
            }
            else
            {
                primeiro = null;
            }
            tamanho--;
            return valor;
        }
        public int RemoverPosicao(int pos)
        {
            if (pos < 0 || pos >= tamanho)
            {
                Console.WriteLine("Posição inválida.");
                return -1;
            }

            if (pos == 0) 
            {
                return RemoverInicio();
            }
            if (pos == tamanho - 1)
            {
                return RemoverFim();
            }
            Celula atual = primeiro;

            for (int i = 0; i < pos; i++)
            {
                atual = atual.prox;
            }
            int valor = atual.valor;
            atual.ante.prox = atual.prox;
            atual.prox.ante = atual.ante;

            tamanho--;
            return valor;
        }
    }
}
