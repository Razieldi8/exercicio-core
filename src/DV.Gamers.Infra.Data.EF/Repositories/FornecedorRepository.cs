using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        protected readonly DVGamersContext _context;

        public FornecedorRepository(DVGamersContext context)
        {
            _context = context;
        }

        public Fornecedor CriarFornecedor(Fornecedor fornecedor)
        {
            _context.Add(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }

        public void Deletar(Guid id)
        {
            var fornecedor = _context.Fornecedores.Find(id);
            _context.Remove(fornecedor);
            _context.SaveChanges();
        }

        public IEnumerable<Fornecedor> ObterFornecedor()
        {
            return _context.Fornecedores;
        }

        public Fornecedor ObterPorId(Guid id)
        {
            return _context.Fornecedores.Find(id);
        }
    }
}
