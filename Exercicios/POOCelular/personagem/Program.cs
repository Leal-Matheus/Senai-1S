using System;

namespace personagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();

            Console.WriteLine("Qual o nome do personagem 1?");
            personagem1.nome = Console.ReadLine();

            Console.WriteLine("Qual a idade do personagem 1?");  
            personagem1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a armadura do personagem 1?");
            personagem1.armadura = Console.ReadLine();

            Console.WriteLine("Quantos pontos de vida o personagem 1 tem?");
            personagem1.pontoVida = int.Parse(Console.ReadLine());

            Personagem personagem2 = new Personagem();
            personagem2.nome = "Visão";
            personagem2.idade = 6;
            personagem2.armadura = "Capa maneira";
            personagem2.pontoVida = 100;

            bool batalha = false;

            Console.WriteLine("Deseja iniciar a batalha? (s/n)");
            string iniciarBatalha = Console.ReadLine();

            if (iniciarBatalha != "s")
            {
                batalha = false;
            }
            else
            {
                batalha = true;
            }

            while (batalha == true)
            {
                Console.WriteLine($@"
            Selecione a opção do personagem 1:
            1 - Atacar
            2 - Defender
            ");
                int opcaoP1 = int.Parse(Console.ReadLine());

                Console.WriteLine($@"
            Selecione a opção do personagem 2:
            1 - Atacar
            2 - Defender
            ");

                int opcaoP2 = int.Parse(Console.ReadLine());

                if (opcaoP1 == 1 && opcaoP2 == 1)
                {
                    personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();

                    personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();
                    
                }
                else if (opcaoP1 == 2 && opcaoP2 == 1)
                {
                    personagem2.pontoVida = personagem2.pontoVida - (personagem1.Atacar() - personagem2.Defender());
                
                }
                else if (opcaoP1 == 1 && opcaoP2 == 2)
                {
                    personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());
                
                }
                else if (opcaoP1 == 2 && opcaoP2 == 2)
                {
                    Console.WriteLine("Os dois persongens defenderam");
                }

                Console.WriteLine($"A vida do {personagem1.nome} esta em {personagem1.pontoVida}");
                Console.WriteLine($"A vida do {personagem2.nome} esta em {personagem2.pontoVida}");

                if (personagem1.pontoVida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O {personagem1.nome} morreu");


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O {personagem2.nome} venceu");

                    
                    break;
                    
                } else if (personagem2.pontoVida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O {personagem2.nome} morreu");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O {personagem1.nome} morreu");
                    break;

                } else if (personagem1.pontoVida <= 0 && personagem2.pontoVida <= 0)
                {
                    Console.WriteLine("Os dois personagens morreram, a batalha terminou em empate");
                }

            }
        }
    }
}
