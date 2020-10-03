using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> ObterPessoa();

        Pessoa ObterPessoa(Guid id);

        Pessoa CriarPessoa(Pessoa pessoa);

        void Deletar(Guid id);

    }
}
