using System;

using Cafe.Classes;

namespace Cafe
{
    class Program
    {
        public int opcaoAcucar;
        public int acucar;
        static void Main(string[] args)
        {
            bool MaquinaLig = false;

            MaquinaCafe m = new MaquinaCafe();

            do
            {
                Console.WriteLine($@"
                ~~~~~~~~~~~~~~||~~~~~~~~~~~~~~
                1 - Café sem açucar
                2 - Café com açucar
                3 - Desligar
                ~~~~~~~~~~~~~~||~~~~~~~~~~~~~~
                ");
                int opcaoCafe = int.Parse(Console.ReadLine());

                switch (opcaoCafe)
                {
                    case 1:
                        m.FazerCafe(m.acucar0);
                        MaquinaLig = true;
                        break;
                    case 2:
                        Console.WriteLine($@"
                        Deseja escolher a quantidade de açucar no café?
                        1 - Sim
                        2 - Não
                        ");
                        int opcaoQuant = int.Parse(Console.ReadLine());
                        if (opcaoQuant == 1)
                        {
                        m.FazerCafe();
                        MaquinaLig = true;                            
                        }else if (opcaoQuant == 2)
                        {
                            m.FazerCafe(m.acucar);
                            MaquinaLig = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Desligando...");
                        MaquinaLig = false;
                        break;
                    default:
                        break;
                }
                
                
            } while (MaquinaLig);

        }
    }
}