using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Components;

namespace ProjetoInstaDev.Models
{
    public class Post : InstadevBase
    {
        public string descricao;
        private int idPost;
        public string imagem;
        public int likes;
        public DateTime DateTime = DateTime.Now;
        public string CadastradoPor;
        
        public string CadastradoPorNome;
        public string CadastradoPorFoto;
        public Usuario usuario;

        private const string PATH = "Database/Posts.csv";

        public Post()
        {
            CriarPastaeArquivo(PATH);
        }

        public string Preparar(Post p)
        {
            return $"{p.descricao};{p.idPost};{p.imagem};{p.likes};{p.CadastradoPor};{p.CadastradoPorNome};{p.CadastradoPorFoto};{p.DateTime}";
        }

        public void CadastrarPost(Post p)
        {
            string[] linha = { Preparar(p) };
            File.AppendAllLines(PATH, linha);
        }

        public List<Post> LerTodos()
        {
            List<Post> posts = new List<Post>();
            string[] lerLinhas = File.ReadAllLines(PATH);

            foreach (var item in lerLinhas)
            {
                string[] cadaLinha = item.Split(";");
                Post post = new Post();

                post.descricao = cadaLinha[0];
                post.idPost = Int32.Parse(cadaLinha[1]);
                post.imagem = cadaLinha[2];
                post.likes = Int32.Parse(cadaLinha[3]);
                post.CadastradoPor = cadaLinha[4];
                post.CadastradoPorNome = cadaLinha[5];
                post.CadastradoPorFoto = cadaLinha[6];
                post.DateTime = DateTime.Parse(cadaLinha[7]);

                posts.Add(post);
            }
            posts.Reverse();
            return posts;
        }

        public void AtualizarPosts(Post p)
        {
            List<string> linhas = LerCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[1] == p.idPost.ToString());
            linhas.Add(Preparar(p));
            ReescreverCSV(PATH, linhas);
        }

        
        public void RemoverPosts(int id)
        {
            List<string> linhas = LerCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[1] == id.ToString());
            ReescreverCSV(PATH, linhas);
        }


        public void AlterarId()
        {
            idPost = GerarId(ReturnIds());
        }

        public List<int> ReturnIds()
        {
            List<int> ids = new List<int>();
            foreach (var item in LerTodos())
            {
                ids.Add(item.idPost);

            }
            return ids;
        }

        public int MostrarId (){
            return this.idPost;
        }

    }
}