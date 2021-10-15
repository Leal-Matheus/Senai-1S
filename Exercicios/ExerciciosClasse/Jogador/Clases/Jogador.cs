using System;

namespace Jogadr.Clases
{
    public abstract class Jogador
    {
        public string nome;
        public int nascimento;
        public string nacionalidade;
        public float altura;
        public float peso;       
        public int idade;

        public void informacoes(){
            Console.WriteLine("Qual o nome do jogador?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o ano de nascimento do jogador?");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nacionalidade do jogador?");
            string nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a altura do jogador?");
            float altura = float.Parse(Console.ReadLine());
        }
        public void Calculo(){
            idade = DateTime.Now.Year - nascimento;
        }
        

    }
}