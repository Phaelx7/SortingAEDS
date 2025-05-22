using System;
using System.Diagnostics;
using Sorting.basic_class.@static;
using Sorting.basic_class.dynamic;
using Sorting.reader;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;
using Sorting.sorting.specials;

public class Program
{
    static int[] vet;
    ReaderFile read;

    public static void Main(string[] args)
    {
        string tipo = "";
        string ordenacao = "";
        string categoria = "";

        //Criando uma instância da própria classe Program
        Program programa = new Program();
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Selecione a categoria que deseja: ");
        Console.WriteLine("SORTING - STATIC - DYNAMIC");
        categoria = Console.ReadLine();

        if (categoria == "SORTING")
        {
            Console.WriteLine("Qual tipo de método quer utilizar?");
            Console.WriteLine("SIMPLES - EFICIENTE - ESPECIAL");
            tipo = Console.ReadLine();
            //Ler o arquivo de texto
            programa.LerTxt(@"inputs\1000000-aleatorios.txt");

            if (tipo == "SIMPLES")
            {
                //Chamar os métodos simples
                Console.WriteLine("Qual Método de ordenação quer utilizar?");
                Console.WriteLine("BubbleSort - InsertionSort - SelectionSort");
                ordenacao = Console.ReadLine();
                switch (ordenacao)
                {
                    case "BubbleSort":
                        Mostrar(BubbleSort.Sorting(vet));
                        break;
                    case "InsertionSort":
                        stopwatch.Start();
                        Mostrar(InsertionSort.Sorting(vet));
                        break;
                    case "SelectionSort":
                        Mostrar(SelectionSort.Sorting(vet));
                        break;
                    default:
                        Console.WriteLine("Não possui esse Método!");
                        break;
                }
            }
            else if (tipo == "EFICIENTE")
            {
                //Chamar os métodos eficientes
                Console.WriteLine("Qual Método de ordenação quer utilizar?");
                Console.WriteLine("HeapSort - MergeSort - QuickSort - ShellSort");
                ordenacao = Console.ReadLine();

                switch (ordenacao)
                {
                    case "HeapSort":
                        Mostrar(HeapSort.Sorting(vet));
                        break;
                    case "MergeSort":
                        Mostrar(MergeSort.Sorting(vet, 0, vet.Length - 1));
                        break;
                    case "QuickSort":
                        Mostrar(QuickSort.Sorting(vet, 0, vet.Length));
                        break;
                    case "ShellSort":
                        Mostrar(ShellSort.Sorting(vet));
                        break;
                    default:
                        Console.WriteLine("Não possui esse Método!");
                        break;
                }
            }
            else if (tipo == "ESPECIAL")
            {
                //Chamar os métodos especiais
                Console.WriteLine("Qual Método de ordenação quer utilizar?");
                Console.WriteLine("BucketSort - CountingSort - RadixSort");
                ordenacao = Console.ReadLine();

                switch (ordenacao)
                {
                    case "BucketSort":
                        Mostrar(BucketSort.Sorting(vet));
                        break;
                    case "CountingSort":
                        //Calcular o valor máximo
                        int max = vet[0];
                        foreach (var num in vet)
                        {
                            if (num > max)
                            {
                                max = num;
                            }
                        }
                        Mostrar(CountingSort.Sorting(vet, max));
                        break;
                    case "RadixSort":
                        Mostrar(RadixSort.Sorting(vet));
                        break;
                    default:
                        Console.WriteLine("Não possui esse Método!");
                        break;
                }
            }
        }
        else if (categoria == "STATIC")
        {
            programa.LerTxt(@"inputs\100-aleatorios.txt");
            Console.WriteLine("Escolha o tipo de estrutura que deseja utilizar: ");
            Console.WriteLine("FILA - LISTA - PILHA");
            tipo = Console.ReadLine();

            if (tipo == "LISTA")
            {
                //Chamar a lista
                programa.LerTxt(@"inputs\10-aleatorios.txt");
                Lista lista = new Lista(1000000);
                while (tipo != "Parar")
                {
                    Console.WriteLine("Digite Ordenar - Mostrar - Parar");

                    tipo = Console.ReadLine();
                    if (tipo == "Ordenar")
                    {
                        for (int i = 0; i < vet.Length; i++)
                        {
                            InsertLista(lista, vet[i]);
                        }
                        QuickSort.Sorting(lista, 0, lista.cont);
                    }
                    else if (tipo == "Mostrar")
                    {
                        lista.Mostrar();
                    }
                }
            }
            else if (tipo == "PILHA")
            {
                //Chamar a pilha
                Console.WriteLine("Pilha: ");
                Pilha pilha = new Pilha(100);

                Console.WriteLine("Deseja Inserir - Remover - Mostrar?");
                tipo = Console.ReadLine();
                if (tipo == "Inserir")
                {
                    Console.WriteLine("Quantas inserções?");
                    int ins = int.Parse(Console.ReadLine());
                    InsertPilha(pilha, ins);
                }
                else if (tipo == "Remover")
                {
                    Console.WriteLine("Quantas remoções?");
                    int remov = int.Parse(Console.ReadLine());
                    RemovePilha(pilha, remov);
                }
                else if (tipo == "Mostrar")
                {
                    pilha.Mostrar();
                }
            }
            else if (tipo == "FILA")
            {
                Console.WriteLine("Lista: ");
                Fila fila = new Fila(100);

                Console.WriteLine("Deseja Inserir - Remover - Mostrar?");
                tipo = Console.ReadLine();
                if (tipo == "Inserir")
                {
                    Console.WriteLine("Quantas inserções?");
                    int ins = int.Parse(Console.ReadLine());
                    InsertFila(fila, ins);
                }
                else if (tipo == "Remover")
                {
                    Console.WriteLine("Quantas remoções?");
                    int remov = int.Parse(Console.ReadLine());
                    RemoveFila(fila, remov);
                }
                else if (tipo == "Mostrar")
                {
                    fila.Mostrar();
                }
            }
        }
        else if (categoria == "DINAMICA")
        {
            programa.LerTxt(@"inputs\100-aleatorios.txt");
            Console.WriteLine("FILA");
            ListaDynamic lista = new ListaDynamic();

            while (tipo != "Parar")
            {
                Console.WriteLine("Digite INSERIR - Ordenar - Parar");
                tipo = Console.ReadLine();
                if (tipo == "INSERIR")
                {
                    Console.WriteLine("DiGITE UM NÚMERO");
                    int ins = int.Parse(Console.ReadLine());
                    lista.Inserirprimeiro(ins);
                    for (int i = 0; i < lista.Tamanho(); i++)
                    {
                        Console.WriteLine("item " + lista.GetItem(i).valor);
                    }
                }
                if (tipo == "Ordenar")
                {
                    for (int i = 0; i < vet.Length; i++)
                    {
                        lista.Inserirprimeiro(vet[i]);
                    }
                    QuickSort.Sorting(lista, 0, lista.Tamanho());
                    lista.Mostrar();
                }
                else if (tipo == "Mostrar")
                {
                    lista.Mostrar();
                }
            }
        }
    }

    public static void InsertFila(Fila fila, int n)
    {
        for (int i = 0; i < n; i++)
        {
            fila.Inserir(vet[i]);
        }
    }

    public static void RemoveFila(Fila fila, int n)
    {
        for (int i = 0; i < n; i++)
        {
            fila.Remover();
        }
    }

    public static void InsertPilha(Pilha pilha, int n)
    {
        for (int i = 0; i < n; i++)
        {
            pilha.Inserir(vet[i]);
        }
    }

    public static void RemovePilha(Pilha pilha, int n)
    {
        for (int i = 0; i < n; i++)
        {
            pilha.Remover();
        }
    }

    public static void InsertLista(Lista lista, int n) //Lista Estática
    {
        lista.InserirFim(n);
    }

    public static void InsertLista(ListaDynamic lista, int n) //Lista encadeada
    {
        lista.Inserirprimeiro(n);
        Console.WriteLine("item:" + lista.GetItem(n).valor);
    }

    public void LerTxt(string tipo)
    {
        //Método para ler o arquivo de texto
        read = new ReaderFile(tipo);
        string[] linha = read.LerLinhaALinha();

        vet = new int[linha.Length];

        for (int i = 0; i < linha.Length; i++)
        {
            vet[i] = int.Parse(linha[i]);
        }
    }

    public static void Mostrar(int[] listaInt)
    {
        //Metodo para mostrar ordenado
        for (int i = 0; i < listaInt.Length; i++)
        {
            //Console.WriteLine(listaInt[i]);
        }
    }
}
