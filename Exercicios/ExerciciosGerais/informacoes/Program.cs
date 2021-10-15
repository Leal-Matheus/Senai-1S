using System;

namespace informacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomeValido = false;
            
            do
            {
                Console.WriteLine("Insira seu nome:");
                string nome = Console.ReadLine();

                if (nome !="")
                {
                    Console.WriteLine("nome guardado no sistema!!");
                    nomeValido = true;

                    
                } else
                {
                    Console.WriteLine("É necessario colocar um nome!!");
                }
            } while (nomeValido == false);

        
            bool idadeValida = false;
            
            do
            {
                Console.WriteLine("Insira sua idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade < 150)
                {
                    Console.WriteLine("idade guardada no sistema!!");
                    idadeValida = true;

                } else{
                    Console.WriteLine("Insira uma idade valida!!");
                }
            } while (idadeValida == false);

            bool salarioValido = false;
            
            do
            {
                Console.WriteLine("Insira seu salario:");
                float salario = float.Parse(Console.ReadLine());

                if (salario > 0)
                {
                    Console.WriteLine("salario guardado no sistema!!");
                    salarioValido = true;
                } else{
                    Console.WriteLine("Insira um salario valido");
                }
            } while (salarioValido == false);

            bool civilValido = false;
            
            do
            {
                Console.WriteLine("Insira seu estado civil (s)solteir@ (c)casad@ (v)viuv@ (d)divorciad@:");
                string estadoCivil = Console.ReadLine();

                if (estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d")
                {
                    Console.WriteLine("estado civil guardado no sistema!!");
                    civilValido = true;
                }else
                {
                    Console.WriteLine("Insira um estado civil valido");
                }
            } while (civilValido == false);
        }
    }
}
