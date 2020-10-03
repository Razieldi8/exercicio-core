using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
    public interface IJogoService
    {
        Jogo CriarJogo(Jogo jogo);
        IEnumerable<Jogo> ObterJogos();
    }
}
