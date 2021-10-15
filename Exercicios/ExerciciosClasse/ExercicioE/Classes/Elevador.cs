using System;

namespace ExercicioE.Classes
{
    public abstract class Elevador
    {
        public int andarAtual;
        public int andares;
        public int capacidade;
        public int pessoas;
        public int CaixasTotal;

        public void Inicializar(){
            andarAtual = 0;

            Console.WriteLine("Quantos andares existem no predio");
            andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade do elevador?");
            capacidade = int.Parse(Console.ReadLine());

        }
        public void Menu(){
            if (andarAtual == 0)
            {
                Console.WriteLine($@"
Você está no térreo 
Existem {pessoas} pessoas no elevador. 
O que você deseja fazer?

1 - Alterar Andar
3 - Entrar Pessoa
4 - Sair Pessoa
5 - Encerrar");

            }else {
                Console.WriteLine($@"
Você está no {andarAtual}°. 

Há {pessoas} pessoas no elevador. 

O que você deseja fazer?

1 - Subir ou descer
3 - Entrar Pessoa
4 - Sair Pessoa
5 - Encerrar");                
            }

        }
        public int Entrar(){
            pessoas = pessoas + 1;
            return pessoas;
        }
        public int Sair(){
            pessoas = pessoas - 1;
            return pessoas;
        }

        public int SubirDescer(){
            do
            {
                Console.Write("Para qual andar deseja ir?");
                andarAtual = int.Parse(Console.ReadLine());

                if (andarAtual < 0 && andarAtual > andares)
                {
                    Console.WriteLine("Este andar não existe");
                }
            } while (andarAtual < 0 && andarAtual > andares);

            return andarAtual;
        }
    }

}

