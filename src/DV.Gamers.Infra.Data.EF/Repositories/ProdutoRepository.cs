using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        protected readonly DVGamersContext _contexto;

        public ProdutoRepository(DVGamersContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Produto> ObterProduto()
        {
            return _contexto.Produtos.Include(p=> p.Categoria);
        }

        public Produto ObterProdutoPorId(Guid id)
        {
            return _contexto.Produtos.Include(p => p.Categoria).FirstOrDefault(p1=> p1.Id == id);
        }

        public Produto CriarProduto(Produto jogo)
        {
            _contexto.Produtos.Add(jogo);
            _contexto.SaveChanges();

            return jogo;
        }

        public void DeletarProduto(Guid id)
        {
            var jogo = _contexto.Produtos.Find(id);
            _contexto.Remove(jogo);
            _contexto.SaveChanges();
        }
    }
}
