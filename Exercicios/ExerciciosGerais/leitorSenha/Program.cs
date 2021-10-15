using System;

namespace leitorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaValida = false;

                Console.WriteLine("Insira o nome do seu usuario:");
                string usuario = Console.ReadLine();
            
            do
            {


                Console.WriteLine("Insira sua senha:");
                string senha = Console.ReadLine();
                
                if (usuario == senha)
                {
                    Console.WriteLine("Sua senha é igual ao nome de usuario!! \n");


                } else {
                    Console.WriteLine("Seu usuario e senha foram registrados!!");
                    respostaValida = true;
                }
            } while (respostaValida == false);
        }
    }
}
