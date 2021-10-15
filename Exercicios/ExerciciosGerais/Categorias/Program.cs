using System;

namespace Categorias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());


            if (idade <=4)
            {
                 Console.WriteLine("Você não pertence a nenhuma categoria");
            }if (idade >=5 && idade <=7)
            {
                Console.WriteLine("Você pertence a categoria infantil A");
            }if (idade >=8 && idade <=10)
            {
                 Console.WriteLine("Você pertence a categoria infantil B");
            }if (idade >=11 && idade <=13)
            {
                Console.WriteLine("Você pertence a categoria Juvenil A");
            }if (idade >=14 && idade <=17)
            {
                Console.WriteLine("Você pertence a categoria Juvenil B");
            }if (idade >=18)
            {
                Console.WriteLine("Você pertence a sênior");
            }
        }
    }
            
}
