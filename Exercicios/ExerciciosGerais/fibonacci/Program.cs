using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Sequencia de Fibonacci");

            int numeroAnterior = 0;
            int numeroAtual = 1;
            int proximoNumero;

            for (int i = 0; i < 14; i++)
            {
                proximoNumero = numeroAtual + numeroAnterior;
                Console.WriteLine(proximoNumero);
                numeroAnterior = numeroAtual;
                numeroAtual = proximoNumero;
            }
        }
    }
}
