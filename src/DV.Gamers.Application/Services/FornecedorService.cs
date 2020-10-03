using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public Fornecedor CriarFornecedor(Fornecedor fornecedor)
        {
            return _fornecedorRepository.CriarFornecedor(fornecedor);
        }

        public void Delete(Guid id)
        {
            _fornecedorRepository.Deletar(id);
        }

        public IEnumerable<Fornecedor> ObterFornecedor()
        {
            return _fornecedorRepository.ObterFornecedor();
        }

        public Fornecedor ObterFornecedorId(Guid id)
        {
            return _fornecedorRepository.ObterPorId(id);
        }
    }
}
