namespace Sorting.basic_class.dynamic
{
    public class Celula
    {
        public int valor;
        public Celula? prox; //Próxima célula
        public Celula? ante; //Célula anterior

        public Celula()
        {
            this.valor = -999; //Valor padrão para indicar que a célula não contém um valor válido
            this.prox = null;
            this.ante = null;
        }

        public Celula(int valor)
        {
            this.valor = valor;
            this.prox = null;
            this.ante = null;
        }
    }
}
