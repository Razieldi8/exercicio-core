using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Pessoa CriarPessoa(Pessoa pessoa)
        {
            return _pessoaRepository.CriarPessoa(pessoa);
        }

        public void Deletar(Guid id)
        {
            _pessoaRepository.Deletar(id);
        }

        public IEnumerable<Pessoa> ObterPessoa()
        {
            return _pessoaRepository.ObterPessoa();
        }

        public Pessoa ObterPessoaPorId(Guid id)
        {
            return _pessoaRepository.ObterPessoa(id);

        }
    }
}
