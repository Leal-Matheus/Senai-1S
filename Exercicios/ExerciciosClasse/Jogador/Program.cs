using System;

using Jogadr.Clases;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a posicao do jogador? (d)Defesa (m)Meio-Campo (a)Ataque");
            string opcao = Console.ReadLine().ToLower();
            

            Console.WriteLine("Qual o nome do jogador?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o ano de nascimento do jogador?");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nacionalidade do jogador?");
            string nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a altura do jogador?");
            float altura = float.Parse(Console.ReadLine());

            switch (opcao)
            {
                case "d":
                    JogadrDefesa d = new JogadrDefesa();
                    d.nome = nome;
                    d.nascimento = nascimento;
                    d.nome = nome;
                    d.nome = nome;
                    d.Calculo();

                    Console.WriteLine($"\nNome: {d.nome}");
                    Console.WriteLine($"Nascimento: {d.nascimento}");
                    Console.WriteLine($"nacionalidade: {d.nacionalidade}");
                    Console.WriteLine($"altura: {d.altura}");
                    d.Aposentar();
                    break;
                case "m":
                    JogadrDefesa m = new JogadrDefesa();
                    m.nome = nome;
                    m.nascimento = nascimento;
                    m.nacionalidade = nacionalidade;
                    m.altura = altura;
                
                    m.Calculo();

                    Console.WriteLine($"\nNome: {m.nome}");
                    Console.WriteLine($"nascimento: {m.nascimento}");
                    Console.WriteLine($"nacionalidade: {m.nacionalidade}");
                    Console.WriteLine($"altura: {m.altura}");
                    m.Aposentar();
                    break;
                case "a":
                    JogadrDefesa a = new JogadrDefesa();
                    a.nome = nome;
                    a.nascimento = nascimento;
                    a.nacionalidade = nacionalidade;
                    a.altura = altura;
                    a.Calculo();

                    Console.WriteLine($"\nNome: {a.nome}");
                    Console.WriteLine($"nascimento: {a.nascimento}");
                    Console.WriteLine($"nacionalidade: {a.nacionalidade}");
                    Console.WriteLine($"altura: {a.altura}");
                    a.Aposentar();
                    break;
                default:
                    Console.WriteLine("Posição invalida");
                    break;
            }
            
        }
    }
}
