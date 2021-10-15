using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetoInstaDev.Models
{
    public class Usuario : InstadevBase
    {
        public string Nome{get; private set;}
        public int id { get;  set; }
        public string UserName{get; private set;}
        public string FotoPerfil { get; private set; }
        public string Email { get; private set; }
        private string Senha { get; set; }

        private const string _path = "Database/Usuario.csv";

        public Usuario()
        {
            CriarPastaeArquivo(_path);
        }
        public string Preparar(Usuario u)
        {
            return $"{u.id};{u.Nome};{u.UserName};{u.Email};{u.Senha};{u.FotoPerfil};";
        }
        public void Alterar(Usuario u, int id)
        {

            List<string> linhas = LerCSV(_path);
            linhas.RemoveAll(x => x.Split(";")[0] == u.id.ToString());
            linhas.Add(Preparar(u));
            ReescreverCSV(_path, linhas);
            u.LerTodos();

        }
        public void Deletar(int id)
        {
            List<string> linhas = LerCSV(_path);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            ReescreverCSV(_path, linhas);
        }
        public void Cadastrar(Usuario u)
        {
            string[] linha = { Preparar(u) };
            File.AppendAllLines(_path, linha);
        }

        public List<Usuario> LerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(_path);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario usuario = new Usuario();
                usuario.id = Int32.Parse(linha[0]);
                usuario.Nome = linha[1];
                usuario.UserName = linha[2];
                usuario.Email = linha[3];
                usuario.Senha = linha[4];
                usuario.FotoPerfil = linha[5];


                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public string RetornoNome()
        {
            return Nome;
        }
        public void AlterarNome(string _nome)
        {
            Nome = _nome;
        }
        public void AlterarUsername(string _username)
        {
            UserName = _username;
        }
        public void AlterarEmail(string _email)
        {
            Email = _email;
        }
        public void AlterarSenha(string _senha)
        {
            Senha = _senha;
        }

        public string RetornoSenha()
        {
            return Senha;
        }
        public void AlterarFotoPerfil(string _foto)
        {
            FotoPerfil = _foto;
        }
        public void AlterarId()
        {
            id = GerarId(ReturnIds());
        }
        public void AlterarId(int _id)
        {
            id = _id;
        }

        public List<int> ReturnIds()
        {
            List<int> ids = new List<int>();
            foreach (var item in LerTodos())
            {
                ids.Add(item.id);
                
            }
            return ids;
        }
    }
}