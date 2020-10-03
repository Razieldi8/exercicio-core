using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
    public interface IFornecedorRepository
    {
        IEnumerable<Fornecedor> ObterFornecedor();
        Fornecedor ObterPorId(Guid id);

        Fornecedor CriarFornecedor(Fornecedor fornecedor);

        void Deletar(Guid id);
    }
}
