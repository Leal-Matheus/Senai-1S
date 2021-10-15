using System;
using System.Collections.Generic;
using System.IO;
using E_playersMVC.Interfaces;

namespace E_playersMVC.Models
{
    public class Jogador : EPlayersBase, IJogador
    {
        public string Nome { get; set; }
        public int IdJogador { get; set; }
        public int IdEquipe { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private const string CAMINHO = "Database/Jogador.csv";

        public Jogador()
        {
            CriarPastaEArquivo(CAMINHO);
        }
        public string Preparar(Jogador j)
        {
            return $"{j.IdJogador};{j.Nome};{j.IdEquipe};{j.Email};{j.Senha}";
        }
        public void Criar(Jogador j)
        {
            string[] linha = { Preparar(j) };
            File.AppendAllLines(CAMINHO, linha);
        }
        public void Alterar(Jogador j)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == j.IdJogador.ToString());
            linhas.Add(Preparar(j));
            ReescreverCSV(CAMINHO, linhas);
        }
        public void Deletar(int id)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            ReescreverCSV(CAMINHO, linhas);
        }
        public List<Jogador> LerTodas()
        {
            List<Jogador> jogadores = new List<Jogador>();

            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Jogador jogador = new Jogador();
                jogador.IdJogador = Int32.Parse(linha[0]);
                jogador.Nome = linha[1];
                jogador.IdEquipe = Int32.Parse(linha[2]);
                jogador.Email = linha[3];
                jogador.Senha = linha[4];

                jogadores.Add(jogador);
            }
            return jogadores;








        }
    }
}
