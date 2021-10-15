using System;

namespace CalculadoraSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do seu salario:");
            double salarioInicial = double.Parse(Console.ReadLine());

            if (salarioInicial < 500)
            {
                double salarioFinal = (salarioInicial / 100) * 30;
                double salarioNovo = salarioFinal + salarioInicial;
                Console.WriteLine("Seu novo salario é: " + salarioNovo);

            } else {
                Console.WriteLine("Seu aumento de salario foi recusado!!");
            }
        }
    }
}
