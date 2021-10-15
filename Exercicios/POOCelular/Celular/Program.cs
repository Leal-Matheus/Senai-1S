using System;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            atributos celular1 = new atributos();


            celular1.modelo = "Iphone 20";
            celular1.cor = "Azul";
            celular1.tamanho = 75.7;
            var ligar = Console.ReadKey();
            Console.WriteLine();

            if (ligar.Key == ConsoleKey.Enter)
            {
                celular1.Ligar();
            }

            while (celular1.Ligar())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
                |=======================|
                | 12:40          100%   |
                |-----------------------|
                |                       |
                |  1. Enviar Mensagem   |
                |                       |
                |  2. Fazer ligação     |
                |                       |
                |  3. Configurações     |
                |                       |
                |  4. Desligar          |
                |                       |
                |-----------------------|
                |   |||     O        <  |
                |=======================|
                ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($@"
|==============================|
|   12:40   3% pouca bateria!! | 
|------------------------------|
|                              |
|  {celular1.MostrarContato()} |
|                              |
|                              |
|                              |
|                              |
|                              |
|                              |
|                              |
|------------------------------|
|      |||     O        <      |
|==============================|
                    ");
                    string pessoa = Console.ReadLine();


                    Console.WriteLine("Digite sua mensagem: \n");
                    string mensagem = Console.ReadLine();

                    Console.WriteLine($"Mensagem '{mensagem}' enviada para {pessoa}");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($@"
|==============================|
|   12:40   2% pouca bateria!! | 
|------------------------------|
|                              |
|  Mensagem '{mensagem}'       | 
|  enviada para {pessoa}       |
|                              |
|                              |
|                              |
| {celular1.MostrarMensagem()} |
|                              |
|                              |
|                              |
|------------------------------|
|      |||     O        <      |
|==============================|

                    ");

                } else if (opcao == "2")
                {

                    Console.WriteLine($@"
                |==============================|
                |   12:40   2% pouca bateria!! | 
                |------------------------------|
                |    Para quem deseja ligar?   |
                | {celular1.MostrarContato()}  | 
                |                              |
                |                              |
                |                              |
                |                              |
                |                              |
                |                              |
                |                              |
                |------------------------------|
                |   |||     O        <         |
                |==============================|

                    ");
                    string pessoaLigacao = Console.ReadLine();

                    Console.WriteLine($@"
                |==============================|
                |   12:40   2% pouca bateria!! | 
                |------------------------------|
                |                              |
                | Ligando para {pessoaLigacao} | 
                |                              |
                |                              |
                |                              |
                |  {celular1.MostrarLigacao()} |
                |                              |
                |                              |
                |                              |
                |                              |
                |------------------------------|
                |   |||     O        <         |
                |==============================|

                    ");

                } else if (opcao == "3")
                {
                    Console.WriteLine($@"
|==============================|
|   12:40   2% pouca bateria!! | 
|------------------------------|
|                              |
|  Configurações do celular:   |
|                              |
|  Modelo: {celular1.modelo}   |
|  Cor: {celular1.cor}         |
|  Tamanho: {celular1.tamanho} | 
|                              |
|                              |
|                              |
|                              |
|                              |
|                              |
|                              |
|                              |
|------------------------------|
|      |||     O        <      |
|==============================|

                    ");

                } else if (opcao == "4")
                {
                    celular1.Desligar();
                    break;
                }
            }
        }
    }
}
