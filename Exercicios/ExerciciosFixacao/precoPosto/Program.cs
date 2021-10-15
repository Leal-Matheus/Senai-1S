using System;

namespace precoPosto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Com qual combustivel deseja abastecer? (G)-Gasolina (A)-Alcool");
            string combustivel = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Quantos litros deseja colocar?");
            int quantidade = int.Parse(Console.ReadLine());

            double valorG = 5.30;
            double valorA = 4.90;

            switch (combustivel)
            {
                case "g":
                    if (quantidade <= 20)
                    {
                        double litroG = quantidade * valorG;
                        double precoFinal = 0.96 * litroG;
                        Console.WriteLine($"O valor a ser pago é de ${precoFinal}");

                    } else if (quantidade > 20)
                    {
                        double litroG = quantidade * valorG;
                        double precoFinal = 0.94 * valorG;
                        Console.WriteLine($"O valor a ser pago é de ${precoFinal}");
                    }
                    break;

                case "a":
                    if (quantidade <=20)
                    {
                        double litroA = quantidade * valorA;
                        double precoFinal = 0.97 * litroA;
                        Console.WriteLine($"O valor a ser pago é de ${precoFinal}");

                    } else if (quantidade > 20)
                    {
                        double litroA = quantidade * valorA;
                        double precoFinal = 0.95 * litroA;
                        Console.WriteLine($"O valor a ser pago é de ${precoFinal}");
                    }

                    break;

                default:

                    break;
            }
            
        }
    }
}
