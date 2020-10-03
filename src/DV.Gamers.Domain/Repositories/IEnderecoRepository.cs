using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
    public interface IEnderecoRepository
    {
        IEnumerable<Endereco> ObterEndereco();

        Endereco ObterEnderecoPorId(Guid id);
        Endereco CriarEndereco(Endereco endereco);
        void DeletarEndereco(Guid id);
    }
}
