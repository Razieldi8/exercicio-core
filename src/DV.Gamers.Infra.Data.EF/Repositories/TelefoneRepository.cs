using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly DVGamersContext _context;

        public TelefoneRepository(DVGamersContext context)
        {
            _context = context;
        }

        public Telefone CriarTelefone(Telefone telefone)
        {
            _context.Add(telefone);
            _context.SaveChanges();
            return telefone;
        }

        public void deletarTelefone(Guid id)
        {
           var telefones = _context.Telefones.Find(id);
            _context.Remove(telefones);
            _context.SaveChanges();
        }

        public IEnumerable<Telefone> ObterTelefone()
        {
            return _context.Telefones;
        }

        public Telefone ObterTelefoneID(Guid id)
        {
            return _context.Telefones.Find(id);
        }
    }
}
