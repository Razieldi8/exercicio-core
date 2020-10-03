using DV.Gamers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Services
{
    public interface ICategoriaService
    {
        IEnumerable<Categoria> ObterCategoria();
        Categoria CriarCategoria(Categoria categoria);
        void deletarCategoria(Guid Id);
        Categoria CriarCategoriaId(Guid Id);
    }
}
