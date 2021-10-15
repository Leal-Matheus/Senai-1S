using System;

namespace produto
{
    class Program
    {
        static int c = 0;
        static int tamanhoArrays = 10;
        static string[] nomes = new string[tamanhoArrays];
        static float[] preco = new float[tamanhoArrays];
        static bool[] promocaoReal = new bool[tamanhoArrays];
        static bool recadastro = true;
        static bool menuPrincipal = true;
        static void Main(string[] args)
        {

            Console.WriteLine($"Deseja ver o menu? (s/n)");
            string abrirMenu = Console.ReadLine().ToLower();

            do
            {
                if (abrirMenu == "s")
                {
                    Menu();
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:

                            recadastro = true;

                            Cadastrar();
                            break;
                        case 2:
                            Listar();
                            break;
                        case 3:
                            AumentarArray();
                            break;
                        default:
                            Console.WriteLine("Até mais!!");

                            menuPrincipal = false;
                            break;
                    }
                } else
                {
                    Console.WriteLine("Você ja cadastrou o maximo de produtos possiveis");                  
                    recadastro = false;
                }



            } while (menuPrincipal);
        }
        static void Menu()
        {
            Console.WriteLine($@"
                |===================================|
                |               MENU                |
                |-----------------------------------|
                |                                   |
                |        1. Cadastrar produto       |
                |                                   |
                |        2. Listar produtos         |
                |                                   |
                |        3. Aumentar quantidade     |
                |                                   |
                |        0. Sair                    |
                |                                   |
                |===================================|
                ");


        }
        static void Cadastrar()
        {
            do
            {
                if (c <= tamanhoArrays)
                {

                    Console.WriteLine("Qual o nome do produto que deseja cadastrar?");
                    nomes[c] = Console.ReadLine();

                    Console.WriteLine("Qual o preço do produto?");
                    preco[c] = float.Parse(Console.ReadLine());

                    Console.WriteLine("O produto esta em promoção? (s/n)");
                    string promocao = Console.ReadLine().ToLower();
                    if (promocao == "n")
                    {
                        promocaoReal[c] = false;
                    }
                    else
                    {
                        promocaoReal[c] = true;
                    }
                    c++;

                    Console.WriteLine("Deseja cadastrar outro produto? (s/n)");
                    string outroProduto = Console.ReadLine().ToLower();
                    if (outroProduto == "n")
                    {
                        recadastro = false;
                    }
                    else
                    {
                        Console.WriteLine("Iniciando novo cadastro...");
                    }
                }else
                {
                    Console.WriteLine("Você ja cadastrou o maximo de produtos possiveis");
                    recadastro = false;
                }
            } while (recadastro);
        }
        static void Listar()
        {
            for (var i = 0; i < c; i++)
            {
                Console.WriteLine($@"|  {nomes[i]}  |  R${preco[i]}  |  {promocaoReal[i]}  |");
            }
            Console.WriteLine("Digite qualque tecla para voltar ao menu"); 
            string voltarMenu = Console.ReadLine().ToLower();

            if (voltarMenu == "")
            {
                Menu();
            }           
        }
        static void AumentarArray()
        {
            Console.WriteLine("Deseja mudar para qual tamanho?");
            int novoTamanho = int.Parse(Console.ReadLine());
            tamanhoArrays = novoTamanho;
            Array.Resize(ref nomes, tamanhoArrays);
            Array.Resize(ref preco, tamanhoArrays);
            Array.Resize(ref promocaoReal, tamanhoArrays);
        }
    }
}
