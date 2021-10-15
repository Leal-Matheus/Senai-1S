using System;
using System.Collections.Generic;


namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produtos : Marca
    {
        public int CodigoProduto;
        public string NomeProduto;
        public float Preco;
        public DateTime DataCadastroPr;
        public Marca Marca { get; set; }
        public Usuario CadastradoPor;
        private List<Produtos> ListaDeProdutos { get; set; }
        List<Produtos> ListaProdutos = new List<Produtos>();

        public Produtos()
        {

        }
        public Produtos(int _codigoProduto, string _nomeProduto, float _preco, Marca _marca, Usuario _cadastradoPor)
        {
            this.CodigoProduto = _codigoProduto;
            this.NomeProduto = _nomeProduto;
            this.Preco = _preco;
            this.Marca = _marca;
            this.CadastradoPor = _cadastradoPor;
            this.ListaDeProdutos = ListaProdutos;

        }

        public string CadastrarProduto(Produtos produtos)
        {

            ListaProdutos.Add(produtos);
            return "Produto cadastrado";
        }
        public string RemoverProduto(Produtos produtos)
        {
            Console.WriteLine($"Qual produto deseja remover?");
            string produtoRemovido = Console.ReadLine();

            ListaProdutos.RemoveAll(x => x.NomeProduto == produtoRemovido);
            return "Produto removido";

        }
        public List<Produtos> ListarProdutos()
        {
            return ListaProdutos;
        }
    }
}
