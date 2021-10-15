using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInstaDev.Models;

namespace ProjetoInstaDev.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Post postModel = new Post();

        [Route("Usuario")]
        public IActionResult Index(){
            ViewBag.Posts = postModel.LerTodos();
            ViewBag.Usuario = usuarioModel.LerTodos();
            ViewBag.Username = HttpContext.Session.GetString("_username");
            ViewBag.NomeUsuario = HttpContext.Session.GetString("_nome");
            ViewBag.FotoUsuario = HttpContext.Session.GetString("_fotoPerfil");
            return View();
        }

        // [Route("MostrarPost")]

        // public IActionResult MostrarPost(){
            
        // }

        

        
    }
}