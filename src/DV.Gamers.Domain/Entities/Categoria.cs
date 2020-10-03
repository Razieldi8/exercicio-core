using System.Collections.Generic;

namespace DV.Gamers.Domain.Entities
{
    public class Categoria : Base
    {

        public string  Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }

    }
}
