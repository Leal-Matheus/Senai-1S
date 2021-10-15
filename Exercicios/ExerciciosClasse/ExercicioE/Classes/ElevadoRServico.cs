using System;

namespace ExercicioE.Classes
{
    public class ElevadoRServico : Elevador
    {
        public int caixas;

        public new void Menu()
        {
            if (andarAtual == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($@"
Você está no Térreo

Há {caixas} caixas.

O que você deseja fazer?

1 - Alterar Andar
2 - Colocar Caixa
3 - Retirar Caixa
4 - Encerrar");
            }
            else
            {
                Console.WriteLine($@"
Você está no {andarAtual}° andar

Há {caixas} caixas.

O que você deseja fazer?

1 - Alterar Andar
2 - Colocar Caixa
3 - Retirar Caixa
4 - Encerrar");
            }
        }

        public int QuantidadeCaixas()
        {
            Console.WriteLine("Qual a capacidade total de caixas do elevador?");
            CaixasTotal = int.Parse(Console.ReadLine());
            return CaixasTotal;
        }
        public int EntrarCaixa()
        {
            caixas = caixas + 1;

            return caixas;
        }
        public int SairCaixa()
        {
            caixas = caixas - 1;

            return caixas;
        }
    }
}
