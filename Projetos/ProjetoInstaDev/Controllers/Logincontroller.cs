using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInstaDev.Models;

namespace ProjetoInstaDev.Controllers
{

    [Route("Login")]
    public class Logincontroller : Controller
    {
        

        [TempData]
        public string Mensagem { get; set; }
        
        
        Usuario usuarioModel = new Usuario();
        public IActionResult index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {

            List<string> UsuariosCSV = usuarioModel.LerCSV("Database/Usuario.csv");

            var logado = UsuariosCSV.Find(
              x =>
              x.Split(";")[3] == form["Email"] &&
              x.Split(";")[4] == form["Senha"]
            );

            if (logado != null)
            {
                HttpContext.Session.SetString("_username", logado.Split(";")[2]);
                HttpContext.Session.SetString("_nome", logado.Split(";")[1]);
                HttpContext.Session.SetString("_fotoPerfil", logado.Split(";")[5]);
                HttpContext.Session.SetString("_id", logado.Split(";")[0]);
                HttpContext.Session.SetString("_Email", logado.Split(";")[3]);
                HttpContext.Session.SetString("_Senha", logado.Split(";")[4]);

                return LocalRedirect("~/Post/Feed");
            }

            Mensagem = "Dados Incorretos! Tente novamente";
            return LocalRedirect("~/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
          HttpContext.Session.Remove("_username");
          return LocalRedirect("~/");
        }

    }
}