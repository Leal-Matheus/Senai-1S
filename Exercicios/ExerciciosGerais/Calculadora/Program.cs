using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sua idade:");
            double idade = double.Parse(Console.ReadLine());

            double meses = idade * 12;
            double dias = idade * 365;
            double horas = idade * 8760;
            double minutos = idade * 525600;

            Console.WriteLine("Sua idade em meses: " + meses);
            Console.WriteLine("Sua idade em dias: " + dias);
            Console.WriteLine("Sua idade em horas: " + horas);
            Console.WriteLine("Sua idade em minutos: " + minutos);
            
        }
    }
}
