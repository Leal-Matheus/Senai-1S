using System;

namespace maiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0, maior = 0;
            int numeroQuantidade = 10;
            int[] numeros = new int[numeroQuantidade];

            Console.WriteLine("Insira 10 numeros inteiros");

            for (var i = 0; i < numeroQuantidade; i++)
            {
                Console.WriteLine($"{i + 1}º numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {


                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }


            }

            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("O maior número é:" + maior);
        }
    }
}
