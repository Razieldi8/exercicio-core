using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
    public interface IJogoRepository
    {
        IEnumerable<Jogo> ObterJogos();
        Jogo ObterPorId(Guid id);
        Jogo CriarJogo(Jogo jogo);
        void DeletarJogo(Guid id);
    }
}
