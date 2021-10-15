using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o ano em que nasceu:");
            int nascimento = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("Insira o ano atual:");
            //int anoAtual = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - nascimento;
            int idadesemana = idade * 52; 

            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Sua idade em semanas é: " + idadesemana);

            
        }
    }
}
