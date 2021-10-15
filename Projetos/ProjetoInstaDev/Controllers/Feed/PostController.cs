using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInstaDev.Models;

namespace ProjetoInstaDev.Controllers.Feed
{

    [Route("Post")]
    public class PostController : Controller
    {
        Post postModel = new Post();
        Usuario UsuarioModel = new Usuario();

        [Route("Feed")]
        public IActionResult Index()
        {
            ViewBag.Posts = postModel.LerTodos();
            ViewBag.Usuarios = UsuarioModel.LerTodos();
            ViewBag.Username = HttpContext.Session.GetString("_username");
            ViewBag.NomeUsuario = HttpContext.Session.GetString("_nome");
            ViewBag.FotoUsuario = HttpContext.Session.GetString("_fotoPerfil");
            return View();
        }

        [Route("CadastrarPost")]

        public IActionResult Cadastrar(IFormCollection form)
        {
            Post novoPost = new Post();
            novoPost.descricao = form["descricao"];

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Posts");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                novoPost.imagem = file.FileName;
            }
            else
            {
                novoPost.imagem = "padrao.png";
            }

            novoPost.AlterarId();
            novoPost.CadastradoPor = HttpContext.Session.GetString("_username");
            novoPost.CadastradoPorNome = HttpContext.Session.GetString("_nome");
            novoPost.CadastradoPorFoto = HttpContext.Session.GetString("_fotoPerfil");
            postModel.CadastrarPost(novoPost);
            ViewBag.Posts = postModel.LerTodos();
            return LocalRedirect("~/Post/Feed");
        }

           [Route("Excluir/{id}")]
           public IActionResult ExcluirPosts(int id)
           {
               postModel.RemoverPosts(id);
               ViewBag.Posts = postModel.LerTodos();
               return LocalRedirect("~/Perfil/Usuario");
           }
    }
}