using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInstaDev.Models;

namespace ProjetoInstaDev.Controllers
{
    [Route ("EdUsuario")]
    public class EditarPerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();

        [Route("EditarPerfil")]
        public IActionResult Index(){
            ViewBag.Usuarios = usuarioModel.LerTodos();
            ViewBag.Username = HttpContext.Session.GetString("_username");
            ViewBag.NomeUsuario = HttpContext.Session.GetString("_nome");
            ViewBag.FotoUsuario = HttpContext.Session.GetString("_fotoPerfil");
            ViewBag.Email = HttpContext.Session.GetString("_Email");
            ViewBag.id = HttpContext.Session.GetString("_id");
            return View();
        }

        [Route("Alterar/{id}")]
        public IActionResult Alterar(IFormCollection form, int id){

            Usuario editarUsuario = new Usuario();
            
            editarUsuario.AlterarNome(form["EditarNomeCompleto"]);
            editarUsuario.AlterarUsername(form["EditarUsername"]);
            editarUsuario.AlterarEmail(form["EditarEmail"]);
            editarUsuario.AlterarFotoPerfil(form["EditarFotoPerfil"]);
            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Usuario");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                editarUsuario.AlterarFotoPerfil(file.FileName);
            }
            else
            {
                editarUsuario.AlterarFotoPerfil(HttpContext.Session.GetString("_fotoPerfil"));
            }

            editarUsuario.AlterarSenha(HttpContext.Session.GetString("_Senha"));
            editarUsuario.AlterarId(Int32.Parse(HttpContext.Session.GetString("_id")));

            usuarioModel.Alterar(editarUsuario, id);
            return LocalRedirect("~/");
        }



        [Route("Deletar/{id}")]
        public IActionResult Deletar(int id){
            usuarioModel.Deletar(id);
            ViewBag.Usuarios = usuarioModel.LerTodos();
            return LocalRedirect("~/Login");
        }
        
    }
}