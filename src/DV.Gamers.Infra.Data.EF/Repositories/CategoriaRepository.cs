using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Infra.Data.EF.Context;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DVGamersContext _context;

        public CategoriaRepository(DVGamersContext context)
        {
            _context = context;
        }

        public Categoria CriarCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public void DeletarCategoria(Guid id)
        {
            var deletarCategoria = _context.Categorias.Find(id);
            _context.Remove(deletarCategoria);
            _context.SaveChanges();

        }

        public IEnumerable<Categoria> ObterCategoria()
        {
            return _context.Categorias;
        }

        public Categoria ObterCategoriaPorId(Guid id)
        {
            return _context.Categorias.Find(id);

        }
    }
}
