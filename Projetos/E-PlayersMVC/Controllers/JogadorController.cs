using System;
using E_playersMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_playersMVC.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        public IActionResult Index(){
            ViewBag.Jogadores = jogadorModel.LerTodas();
            return View();
        }
        Jogador jogadorModel = new Jogador();

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form){
            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];

            jogadorModel.Criar(novoJogador);
            
            ViewBag.Jogadores = jogadorModel.LerTodas();
            return LocalRedirect("~/Jogador");
        }
        [Route("Excluir/{id}")]
        public IActionResult Ecluir(int id){
            jogadorModel.Deletar(id);
            ViewBag.Equipes = jogadorModel.LerTodas();
            return LocalRedirect("~/Equipe/Listar");
        }
    }
}   