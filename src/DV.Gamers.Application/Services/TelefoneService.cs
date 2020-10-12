using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public Telefone CriarTelefone(Telefone telefone)
        {
           return _telefoneRepository.CriarTelefone(telefone);
        }

        public void DeletarTelefone(Guid id)
        {
            _telefoneRepository.deletarTelefone(id);
        }

        public IEnumerable<Telefone> ObterTelefone()
        {
            return _telefoneRepository.ObterTelefone();
        }

        public Telefone ObterTelefoneId(Guid id)
        {
            return _telefoneRepository.ObterTelefoneID(id);
        }
    }
}
