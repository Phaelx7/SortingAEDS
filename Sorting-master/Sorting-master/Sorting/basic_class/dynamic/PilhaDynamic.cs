namespace Sorting.basic_class.dynamic;
class PilhaDynamic
{
    private Celula? topo;
    private int tamanho;

    public PilhaDynamic()
    {
        topo = null;
        tamanho = 0;
    }
    public bool EstaVazia()
    {
        return topo == null;
    }
    public int Tamanho()
    {
        return tamanho;
    }
    public bool Inserir(int item)
    {
        Celula nova = new Celula(item);
        if (!EstaVazia())
        {
            nova.ante = topo;
            topo.prox = nova;
        }
        nova.prox = topo;
        topo = nova;
        tamanho++;
        return true;
    }
    public int Remover()
    {
        if (EstaVazia())
        {
            Console.WriteLine("Pilha vazia");
            return -1;
        }
        int valor = topo.valor;
        topo = topo.prox;
    
        if (topo != null)
        {
            topo.prox = null;
        }
        tamanho--;
        return valor;
    }
}
