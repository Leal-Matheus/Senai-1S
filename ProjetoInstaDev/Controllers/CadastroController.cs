using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInstaDev.Models;

namespace ProjetoInstaDev.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        Usuario usuarioModel = new Usuario();
        public IActionResult Index()
        {
            ViewBag.Usuario = usuarioModel.LerTodos();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastro(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();
            List<string> UsuarioCSV = usuarioModel.LerCSV("Database/Usuario.csv");
            novoUsuario.AlterarNome(form["Nome Completo"]);
            novoUsuario.AlterarUsername(form["Nome de Usuário"]);
            novoUsuario.AlterarEmail(form["Email"]);
            novoUsuario.AlterarSenha(form["Senha"]);

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novoUsuario.AlterarFotoPerfil(file.FileName);

            }
            else
            {
                novoUsuario.AlterarFotoPerfil("padrao.png");
            }

            novoUsuario.AlterarId();

            novoUsuario.Cadastrar(novoUsuario);
            ViewBag.Usuario = novoUsuario.LerTodos();
            return LocalRedirect("~/Login");
        }
    }
}