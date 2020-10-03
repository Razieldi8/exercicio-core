using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        protected readonly DVGamersContext _contexto;

        public JogoRepository(DVGamersContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Jogo> ObterJogos()
        {
            return _contexto.Jogos;
        }

        public Jogo ObterPorId(Guid id)
        {
            return _contexto.Jogos.Find(id);
        }

        public Jogo CriarJogo(Jogo jogo)
        {
            _contexto.Jogos.Add(jogo);
            _contexto.SaveChanges();

            return jogo;
        }

        public void DeletarJogo(Guid id)
        {
            var jogo = _contexto.Jogos.Find(id);
            _contexto.Remove(jogo);
            _contexto.SaveChanges();
        }
    }
}
