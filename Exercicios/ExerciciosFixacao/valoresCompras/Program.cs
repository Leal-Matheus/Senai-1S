using System;

namespace valoresCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o produto que você esta comprando?");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantas unidades deste produto você esta levando?");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da unidade deste produto?");
            double preco = double.Parse(Console.ReadLine());

            double valorTotal = quantidade * preco;


            if (quantidade <= 5)
            {
                double valorFinal =  0.98 * valorTotal;
                Console.WriteLine($"O valor total a se pagar é de ${valorFinal}");
                
            } else if (quantidade > 5 && quantidade <= 10)
            {
                double valorFinal = 0.97 * valorTotal;
                Console.WriteLine($"O valor total a se pagar é de ${valorFinal}");
                
            }else if (quantidade > 10)
            {
                double valorFinal = 0.95 * valorTotal;
                Console.WriteLine($"O valor total a se pagar é de ${valorFinal}");
                
            }
        }
    }
}
