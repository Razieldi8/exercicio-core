using System;

namespace DV.Gamers.Domain.Entities
{
    public class Produto : Base
    {
        public string Descriacao { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
