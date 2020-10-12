using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
   public interface ITelefoneService
    {
        IEnumerable<Telefone> ObterTelefone();
        Telefone CriarTelefone(Telefone telefone);
        Telefone ObterTelefoneId(Guid id);
        void DeletarTelefone(Guid id);
    }
}
