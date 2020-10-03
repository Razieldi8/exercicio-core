using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
    public interface IFornecedorService
    {
        IEnumerable<Fornecedor> ObterFornecedor();

        Fornecedor CriarFornecedor(Fornecedor fornecedor);

        Fornecedor ObterFornecedorId(Guid Id);

        void Delete(Guid id);
    }
}
