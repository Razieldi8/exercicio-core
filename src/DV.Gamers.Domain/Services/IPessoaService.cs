using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> ObterPessoa();

        Pessoa ObterPessoaPorId(Guid id);

        Pessoa CriarPessoa (Pessoa pessoa);

        void Deletar(Guid id);

    }
}
