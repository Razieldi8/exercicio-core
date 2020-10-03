using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public Endereco CriarEndereco(Endereco endereco)
        {
            return _enderecoRepository.CriarEndereco(endereco);
        }

        public Endereco CriarEnderecoPorId(Guid id)
        {
            return _enderecoRepository.ObterEnderecoPorId(id);
        }

        public void DeletarEndereco(Guid id)
        {
            _enderecoRepository.DeletarEndereco(id);
        }

        public IEnumerable<Endereco> ObterEndereco()
        {
            return _enderecoRepository.ObterEndereco();
        }
    }
}
