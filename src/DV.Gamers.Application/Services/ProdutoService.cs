using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using DV.Gamers.Infra.Data.EF.Context;
using DV.Gamers.Infra.Data.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto CriarProduto(Produto jogo)
        {
            return _produtoRepository.CriarProduto(jogo);
        }

        public IEnumerable<Produto> ObterProduto()
        {
            return _produtoRepository.ObterProduto();
        }

        public Produto ObterProdutoPorId(Guid id)
        {
            return _produtoRepository.ObterProdutoPorId(id);
        }
    }
}
