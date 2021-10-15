using System;

namespace nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            int nomesQuantidade = 10;
            string[] nomes = new string[nomesQuantidade];

            Console.WriteLine("Insira 10 nomes:");

            for (var i = 0; i < nomesQuantidade; i++)
            {
                Console.WriteLine($"{i + 1}º nome");
                nomes[i] = Console.ReadLine();
                
            } 
            foreach (var item in nomes)
            {
                Console.WriteLine("Insira um nome para busca:");
                string nomeBusca = Console.ReadLine();


                if (item == nomeBusca)
                {
                    Console.WriteLine("ACHEI!!!");
                } else
                {
                    Console.WriteLine("NÃO ACHEI!!!!");

                }
            }



        }
    }
}

