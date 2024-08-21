using System.Collections;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void imprimirLista(List<string> listas)
    {
        /*      Imprimindo Novamente                */

        Console.WriteLine(); //Pular linha

        Console.WriteLine("Minha Lista de Frutas: ");
        foreach (string lista in listas)
        {
            Console.WriteLine(lista);
        }
    }

    private static void Main(string[] args)
    {
        // TRABALHANDO COM LISTA ( LIST )

        //Criando uma lista
        List<string> frutas = new List<string>();

        /* Adicionar itens na Lista */
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /* Imprimir os Itens da Lista */

        imprimirLista(frutas);

        /* imprimir elemento na posição específica */
        Console.WriteLine("Fruta no índice 2: " + frutas[2]);

        /* Inserir elemento em índice especifico */

        frutas.Insert(2, "Maracujá");


        /*      Imprimindo Novamente                */

        imprimirLista(frutas);

        /*     Alterar elemento de um Índice      */
        frutas[4] = "Melancia";


        /*      Imprimindo Novamente                */

        imprimirLista(frutas);

        /*    Removendo um elemento   da lista por índice específico  */
        frutas.RemoveAt(2);


        /*      Imprimindo Novamente                */
        Console.WriteLine(); //Pular linha

        Console.WriteLine("Minha Lista de Frutas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }


        /* Remover elementos pelo valor do elemento/conteúdo */
        frutas.Remove("Morango");


        /*      Imprimindo Novamente                */
        imprimirLista(frutas);


        /* Apagar todos os elementos da lista */
        frutas.Clear();



        imprimirLista(frutas);

        /* EXEMPLO SOBRE (DICTIONARY) */

        /*  Criando um Dicionário de Dados */
        Dictionary<int, string> carros = new Dictionary<int, string>();

        carros.Add(5, "Silvia S14");
        carros.Add(10, "Honda 180SX");
        carros.Add(2, "M3 Competition");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Meu dicionário de Carros: ");
        /*  Imprimir um Dicionário de Dados  */
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();

        //  TRABALHANDO COM FILA //

        /* Criar uma Fila (Queue) */
        Queue<string> filaBanco = new Queue<string>();


        /* Adicionar elementos em uma Fila */

        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");


        //Imprimindo a Fila
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);


        }
        Console.WriteLine();


        //Remover o primeiro elemento na Fila
        filaBanco.Dequeue();


        //Imprimindo a Fila
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);

        }
        Console.WriteLine();


        /* Verificar se há um elemento existente na Fila */
        bool found = filaBanco.Contains("Bia");

        if (found == true)
        {
            Console.WriteLine(" A pessoa está presente na fila.");

        }
        else
        {
            Console.WriteLine(" A pessoa NÃO está presente na fila.");
        }

        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();


        // Trabalhando com PILHA(STACK) //

        /* Criando uma Pilha */
        Stack<string> livros = new Stack<string>();


        /* Adicionar elementos em uma pilha */
        livros.Push("Chhapeuzinho Vermelho");
        livros.Push("Branca de Neve");
        livros.Push("Princesa e o Sapo");


        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();


        /* Remove o primeiro elemento da Pilha */
        livros.Pop();


        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();


    }



}


