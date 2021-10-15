using System;

namespace PrimeiroExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a primeira nota");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a segunda nota");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a terceircleara nota");
            double n3 = double.Parse(Console.ReadLine());

            double notaFinal = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média das suas notas foi: " + notaFinal.ToString("N1"));

            if (notaFinal > 5)
            {
                Console.WriteLine("O aluno foi aprovado!!");
            }else {
                Console.WriteLine("O aluno foi reprovado!!");
            }

        }
    }
}
