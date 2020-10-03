using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
   public interface IEnderecoService
    {
        IEnumerable<Endereco> ObterEndereco();
        Endereco CriarEndereco(Endereco endereco);
        Endereco CriarEnderecoPorId(Guid id);
        void DeletarEndereco(Guid id);
    }
}
