using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
   public class EnderecoRepository : IEnderecoRepository
    {
        private readonly DVGamersContext _context;

        public EnderecoRepository(DVGamersContext context)
        {
            _context = context;
        }

        public Endereco CriarEndereco(Endereco endereco)
        {
            _context.Add(endereco);
            _context.SaveChanges();
            return endereco;
        }

        public void DeletarEndereco(Guid id)
        {
            var endereco = _context.Enderecos.Find(id);
            _context.Remove(endereco);
            _context.SaveChanges();
        }

        public IEnumerable<Endereco> ObterEndereco()
        {
            return _context.Enderecos;
        }

        public Endereco ObterEnderecoPorId(Guid id)
        {
            return _context.Enderecos.Find(id);

        }
    }
}
