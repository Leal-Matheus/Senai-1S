using System.Collections.Generic;
using E_playersMVC.Models;

namespace E_playersMVC.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);

        List<Equipe> LerTodas();

        void Alterar(Equipe e);

        void Deletar(int id);
            
        
    }
}