using System;

using ExercicioE.Classes;

namespace ExercicioE
{
    class Program
    {
        static string opcaoCaixa;
        static bool Valido = true;
        static bool ValidoMenu = false;
        static string opcao;
        static void Main(string[] args)
        {
            ElevadoRServico se = new ElevadoRServico();
            ElevadoRSocial so = new ElevadoRSocial();

            do
            {
            Console.WriteLine($@"
            ~~~~~~~~~~~~||~~~~~~~~~~~~ 
            1 - Elevador Social
            2 - Elevador de serviço
            ~~~~~~~~~~~~||~~~~~~~~~~~~ 
            
            ");
            opcao = Console.ReadLine().ToLower();



                switch (opcao)
                {

                    case "1":
                        se.Inicializar();
                        se.QuantidadeCaixas();
                        do
                        {
                            se.Menu();
                            string opcao = Console.ReadLine();
                            switch (opcao)
                            {


                                case "1":

                                    se.SubirDescer();

                                    break;

                                case "2":
                                    se.EntrarCaixa();
                                    if (se.caixas > se.CaixasTotal)
                                    {
                                        Console.WriteLine("Não é possível adicionar mais caixas no elevador");
                                        se.SairCaixa();
                                    }
                                    break;
                                case "3":

                                    se.SairCaixa();
                                    if (se.caixas < 0)
                                    {
                                        Console.WriteLine("Não há caixas para retirar");
                                        se.EntrarCaixa();
                                    }

                                    break;

                                case "4":
                                    Console.WriteLine("Até mais!!");
                                    Valido = false;
                                    ValidoMenu = true;
                                    break;

                                default:
                                    Console.WriteLine("Opção Invalida!!");
                                    break;
                            }
                        } while (Valido);
                        break;
                    case "2":
                        so.Inicializar();
                        do
                        {

                            so.Menu();

                            string opcao = Console.ReadLine();
                            switch (opcao)
                            {

                                case "1":
                                    so.SubirDescer();
                                    break;

                                case "3":
                                    so.Entrar();
                                    if (so.capacidade < so.pessoas)
                                    {
                                        Console.WriteLine("Não é possível adicionar mais pessoas no elevador");
                                        so.Sair();
                                    }
                                    break;

                                case "4":
                                    so.Sair();
                                    if (so.pessoas < 0)
                                    {
                                        Console.WriteLine("Não há mais pessoas no elevador");
                                        so.Entrar();
                                    }

                                    break;

                                case "5":
                                    Console.WriteLine("Até mais!!");
                                    Valido = false;
                                    ValidoMenu = true;
                                    break;

                                default:
                                    Console.WriteLine("Opção invalida!!");
                                    break;
                            }
                        } while (Valido);
                        break;
                    default:
                        Console.WriteLine("Opção invalida!!");
                        ValidoMenu = false;
                        break;
                }
            } while (!ValidoMenu);

        }
    }
}
