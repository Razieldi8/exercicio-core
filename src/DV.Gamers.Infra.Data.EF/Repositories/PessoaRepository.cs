using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DVGamersContext _context;

        public PessoaRepository(DVGamersContext context)
        {
            _context = context;
        }

        public Pessoa CriarPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return pessoa;
        }

        public void Deletar(Guid id)
        {
            var pessoa = _context.Pessoas.Find(id);
            _context.Remove(pessoa);
            _context.SaveChanges();
        }

        public IEnumerable<Pessoa> ObterPessoa()
        {
            return _context.Pessoas;
            
        }

        public Pessoa ObterPessoa(Guid id)
        {
            return _context.Pessoas.Find(id);
        }
    }
}
