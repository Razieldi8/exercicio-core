using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
   public interface ITelefoneRepository
    {
        IEnumerable<Telefone> ObterTelefone();
        Telefone CriarTelefone(Telefone telefone);
        void deletarTelefone(Guid id);
        Telefone ObterTelefoneID(Guid id);
    }
}
