using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
    public interface IProdutoService
    {
        Produto CriarProduto(Produto jogo);
        IEnumerable<Produto> ObterProduto();
        Produto ObterProdutoPorId(Guid id);
    }
}
