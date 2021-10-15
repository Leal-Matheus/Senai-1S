using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;


namespace AulaPOO_ProjetoDeProdutos
{
    public class Usuario : IUsuario
    {
        public int Codigo;
        public string Nome;
        public string Email;
        public string Senha;
        public DateTime DataCadastroUsuario;
        public List<Usuario> usuarios = new List<Usuario>();
        public Usuario()
        {

        }
        public Usuario(int _codigo, string _nome, string _email, string _senha)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            DataCadastroUsuario = DateTime.Now;
        }
        public void Cadastrar(Usuario usuario)
        {

        }

        public string cadastrar(Usuario usuario)
        {
            usuarios.Add(usuario);
            return "Cadastro efetuado";
        }

        public string Deletar(Usuario usuario)
        {
            usuarios.Remove(usuario);
            return "Cadastro deletado";
        }

    }
}