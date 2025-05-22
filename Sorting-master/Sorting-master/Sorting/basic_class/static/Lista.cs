namespace Sorting.basic_class.@static
{
    public class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }
        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }
        public bool InserirInicio(int item)
        {
            if (cont >= lista.Length)
            {
                Console.WriteLine("Lista está cheia, não é possível inserir no início");
                return false;
            }
            for (int i = cont; i > 0; i--)
            {
                lista[i] = lista[i - 1];
            }

            lista[0] = item;
            cont++;
            return true;
        }
        public bool InserirPosicao(int pos, int item)
        {
            if (cont >= lista.Length || pos < 0 || pos > cont)
            {
                Console.WriteLine("Posição inválida ou lista cheia");
                return false;
            }

            for (int i = cont; i > pos; i--)
            {
                lista[i] = lista[i - 1];
            }

            lista[pos] = item;
            cont++;
            return true;
        }
        public int RemoverFim()
        {
            if (cont == 0)
            {
                Console.WriteLine("Lista vazia, não é possível remover do fim.");
                return -1;
            }

            cont--;
            return lista[cont];
        }
        public int RemoverInicio()
        {
            if (cont == 0)
            {
                Console.WriteLine("Lista vazia, não é possível remover do início.");
                return -1;
            }

            int removido = lista[0];

            for (int i = 0; i < cont - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

            cont--;
            return removido;
        }
        public int RemoverPosicao(int pos)
        {
            if (cont == 0 || pos < 0 || pos >= cont)
            {
                Console.WriteLine("Posição inválida ou lista vazia.");
                return -1;
            }
            int removido = lista[pos];
            for (int i = pos; i < cont - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

            cont--;
            return removido;
        }
        public void Mostrar()
        {
            Console.WriteLine(" Lista ");
            for (int i = 0; i < cont; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
