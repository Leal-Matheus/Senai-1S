using System;

namespace Cafe.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;

        public int padrao = 10;

        public int acucar;

        public string acucar0;

        public void FazerCafe()
        {
            if (acucarDisponivel == 0)
            {
                Console.WriteLine("O açucar acabou!!");
            }
            else
            {
                Console.WriteLine("Quantas gramas de açucar deseja utilizar?");
                acucar = int.Parse(Console.ReadLine());

                if (acucarDisponivel < acucar)
                {
                    Console.WriteLine("Quantidade de açucar insuficiente");
                }
                else if (acucarDisponivel >= acucar)
                {

                    acucarDisponivel = acucarDisponivel - acucar;
                    Console.WriteLine($"Café feito com {acucar}g de açucar!!");
                    Console.WriteLine($"Agora restam {acucarDisponivel}g de açucar na maquina");

                }
            }
        }
        public void FazerCafe(int acucar)
        {
            if (acucarDisponivel < padrao)
            {
                Console.WriteLine("Quantidade de açucar insuficiente");
            }
            else if (acucarDisponivel >= padrao)
            {
                Console.WriteLine($"A quantidade padrão de {padrao}g de açucar foi colocada no café");

                acucarDisponivel = acucarDisponivel - padrao;
                Console.WriteLine($"Agora restam {acucarDisponivel}g de açucar na maquina");

            }

        }
        public void FazerCafe(string acucar0){
            Console.WriteLine("Fazendo café sem açucar...");

            Console.WriteLine($"A quantidade de açucar continua a mesma {acucarDisponivel}g");
        }

    }
}
