using System.Collections.Generic;
using E_playersMVC.Models;

namespace E_playersMVC.Interfaces
{
    public interface IJogador
    {
        void Criar(Jogador j);

        List<Jogador> LerTodas();

        void Alterar(Jogador j);

        void Deletar(int id);
    }
}