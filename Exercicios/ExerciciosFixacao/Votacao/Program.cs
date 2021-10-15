using System;

namespace Votacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o ano de seu nascimento:");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - nascimento;

            if (idade >= 16)
            {
                Console.WriteLine($"Você possui {idade} anos, ja pode votar!!");
            } else
            {
                Console.WriteLine($"Você possui {idade} anos, ainda não pode votar!!");                
            }
        }
    }
}
