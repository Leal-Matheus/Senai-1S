using System;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaValida = false;

            while (respostaValida == false)
            {
                Console.WriteLine("Insira uma nota:");
                int nota = int.Parse(Console.ReadLine());

                if (nota < 10)
                {
                    Console.WriteLine("Sua nota foi guardada no sistema!!");
                    respostaValida = true;

                }
                else
                {
                    Console.WriteLine("Esta não é uma nota valida!!");
                    Console.WriteLine("Insira uma nota valida:");
                }
            }
        }
    }
}