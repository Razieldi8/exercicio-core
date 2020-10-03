using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Repositories;
using DV.Gamers.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Categoria CriarCategoria(Categoria categoria)
        {
            return _categoriaRepository.CriarCategoria(categoria);
        }

        public Categoria CriarCategoriaId(Guid id)
        {
            return _categoriaRepository.ObterCategoriaPorId(id);
        }

        public void deletarCategoria(Guid id)
        {
            _categoriaRepository.DeletarCategoria(id);
        }

        public IEnumerable<Categoria> ObterCategoria()
        {
            return _categoriaRepository.ObterCategoria();
        }
    }
}
