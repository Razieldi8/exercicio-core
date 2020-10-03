using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ObterCategoria();
        Categoria CriarCategoria(Categoria categoria);
        void DeletarCategoria(Guid id);
        Categoria ObterCategoriaPorId(Guid id);
    }
}
