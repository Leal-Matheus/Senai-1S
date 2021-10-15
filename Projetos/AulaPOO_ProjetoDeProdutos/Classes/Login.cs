using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Classes;
using AulaPOO_ProjetoDeProdutos.Interfaces;

namespace AulaPOO_ProjetoDeProdutos
{
    public class login
    {
        public bool Logado { get; set; }
        Usuario EncontrarUsuario;
        public login()
        {

            Marca marca = new Marca();
            Produtos produtos = new Produtos();
            Usuario usuario = new Usuario();
            int c = 0;
            bool decisao = false;
            bool checagem = false;

            do
            {
                Console.WriteLine(@"
|========================|
   O que deseja fazer:   
                        
   1- Cadastrar Marca    
   2- Listar Marcas
   3- Deletar Marca
   4- Cadastrar Produto    
   5- Listar Produtos
   6- Deletar Produto
   7- Cadastrar Usuario    
   8- Deletar Usuario
   9- Logar
   10- Deslogar
   0- Sair

                        
|========================|  
Resposta: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (Logado)
                        {
                            Marca marca_ = new Marca();
                            Console.Write("Digite o nome da marca que deseja cadastrar: ");
                            marca_.nomeMarca = Console.ReadLine();


                            c++;
                            marca_.CodigoMarca = c;
                            marca_.DataCadastro = DateTime.Now;
                            Console.WriteLine(marca.CadastrarMarca(marca_));

                            decisao = false;
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }
                        break;

                    case "2":

                        List<Marca> ListaMarcas = marca.Listar();

                        if (Logado)
                        {
                            foreach (var m in ListaMarcas)
                            {
                                Console.Write($@"
___________________________
| Marca: {m.nomeMarca}            |
|                          |
| Cod: {m.CodigoMarca}                   |  
| Data: {m.DataCadastro}|
|                          |
|__________________________|     
                  ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");

                        }
                        break;

                    case "3":
                        if (Logado)
                        {
                            Marca marca1 = new Marca();

                            Console.WriteLine(marca.RemoverMarca(marca1));
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }

                        break;

                    case "4":

                        if (Logado)
                        {
                            Produtos produtos_ = new Produtos();
                            Console.Write("Digite o nome do produto que deseja cadastrar: ");
                            produtos_.NomeProduto = Console.ReadLine();

                            Console.Write("Digite o preço do produto: ");
                            produtos_.Preco = float.Parse(Console.ReadLine());

                            Console.Write("De qual marca esse produto pertence: ");
                            string produtoMarca = Console.ReadLine();

                            Usuario _cadastradoPor = EncontrarUsuario;

                            c++;
                            produtos_.CodigoProduto = c;
                            produtos_.DataCadastroPr = DateTime.Now;
                            Console.WriteLine(produtos.CadastrarProduto(produtos_));

                            decisao = false;

                        }

                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }


                        break;

                    case "5":

                        List<Produtos> ListaProdutos = produtos.ListarProdutos();

                        if (Logado)
                        {
                            foreach (var p in ListaProdutos)
                            {
                                Console.Write($@"
___________________________
|                          |
| Produto: {p.NomeProduto}
| Preço: R${p.Preco}         |
| Cod: {p.CodigoProduto}          |  
| Data: {p.DataCadastroPr}
| Cadastrado: {p.CadastradoPor}|
|                          |
|__________________________|     
                  ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");

                        }
                        break;
                    case "6":
                        if (Logado)
                        {
                            Produtos produtoRemover = new Produtos();

                            Console.WriteLine(produtos.RemoverProduto(produtoRemover));
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }

                        break;

                    case "7":
                        Usuario usuario_ = new Usuario();

                        Console.Write("Digite o seu nome: ");
                        usuario_.Nome = Console.ReadLine();

                        Console.Write("Digite o seu Email: ");                       
                        usuario_.Email = Console.ReadLine();

                        Console.Write("Digite a sua senha: ");
                        usuario_.Senha = Console.ReadLine();

                        c++;
                        usuario_.Codigo = c;
                        usuario_.DataCadastroUsuario = DateTime.Now;
                        Console.WriteLine(usuario.cadastrar(usuario_));

                        decisao = false;

                        break;
                    case "8":
                        if (Logado)
                        {
                            Usuario usuarioRemover = new Usuario();

                            Console.WriteLine(usuario.Deletar(usuarioRemover));
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }

                        break;
                    case "9":
                        do
                        {
                            Console.WriteLine("Digite seu email: ");
                            string emailLogar = Console.ReadLine().ToLower();
                            Console.WriteLine("Digite sua senha: ");
                            string senhaLogar = Console.ReadLine();

                            EncontrarUsuario = usuario.usuarios.Find(x => x.Email == emailLogar && x.Senha == senhaLogar);

                            if (EncontrarUsuario != null)
                            {
                                Console.WriteLine(Logar(usuario));
                                checagem = false;
                            }
                            else
                            {
                                Console.WriteLine("O email ou a senha estão incorretos");
                            }
                        } while (checagem == true);
                        checagem = true;
                        break;
                    case "10":
                        do
                        {
                            Console.WriteLine("Digite seu email para deslogar: ");
                            string emailDeslogar = Console.ReadLine().ToLower();
                            Console.WriteLine("Digite sua senha para deslogar: ");
                            string senhaDeslogar = Console.ReadLine();
                            if (usuario.usuarios.Find(x => x.Email == emailDeslogar).Senha == senhaDeslogar)
                            {
                                Console.WriteLine(Deslogar(usuario));
                                checagem = false;
                            }
                            else
                            {
                                Console.WriteLine("O email ou a senha estão incorretos");
                            }
                        } while (checagem == true);
                        checagem = true;
                        break;
                    case "0":
                        Console.WriteLine("Até mais!!!");
                        decisao = true;
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            } while (decisao == false);
        }
        public string Logar(Usuario usuario)
        {
            if (Logado == false)
            {
                Logado = true;
                return ("Você foi logado");
            }
            return ("Você já está logado!");
        }
        public string Deslogar(Usuario usuario)
        {
            if (Logado == true)
            {
                Logado = false;
                return ("Você foi deslogado");
            }
            return ("Você já está deslogado!");
        }
    }
}