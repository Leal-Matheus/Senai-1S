using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quantidade = new int[15];
            int i;

            Console.WriteLine("\nDigite 15 valores inteiros\n");

            for (i = 0; i < 15; i++)
            {
                Console.WriteLine($"{i + 1}º numero");
                quantidade[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n Seus numeros na ordem inversa são: \n");
            for (i = 14; i >= 0; i--)
                Console.WriteLine(quantidade[i]);
                Console.ReadKey();

        }
    }
}
