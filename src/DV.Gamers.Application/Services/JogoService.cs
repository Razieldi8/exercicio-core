using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using DV.Gamers.Infra.Data.EF.Context;
using DV.Gamers.Infra.Data.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class JogoService : IJogoService
    {

        private readonly IJogoRepository _jogoRepository;

        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public Jogo CriarJogo(Jogo jogo)
        {
            return _jogoRepository.CriarJogo(jogo);
        }

        public IEnumerable<Jogo> ObterJogos()
        {
            return _jogoRepository.ObterJogos();
        }
    }
}
