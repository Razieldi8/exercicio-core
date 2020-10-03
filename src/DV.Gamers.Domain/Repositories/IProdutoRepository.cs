using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ObterProduto();
        Produto ObterProdutoPorId(Guid id);
        Produto CriarProduto(Produto jogo);
        void DeletarProduto(Guid id);
    }
}
