using System;

namespace DV.Gamers.API.ViewModel
{
    public class ProdutoViewModel
    {
        public string Descriacao { get; set; }
        public bool Ativo { get; set; }
        public Guid CategoriaId { get; set; }
    }
}
